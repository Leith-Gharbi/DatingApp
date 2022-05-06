using API.DTOs;
using API.Entities;
using API.Extensions;
using API.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class LikesRepository : ILikesRepository
    {
        private readonly DataDbContext _context;

        public LikesRepository(DataDbContext context, IMapper mapper)
        {
            _context = context;
        }
        public async Task<UserLike> GetUserLike(int sourceUserId, int likeUserId)
        {
            return await _context.Likes.FindAsync(sourceUserId, likeUserId);
        }

        public async Task<IEnumerable<LikeDto>> GetUserLikes(string predicate, int userId)
        {

            var users = _context.Users.OrderBy(u => u.UserName).AsQueryable();
            var likes = _context.Likes.AsQueryable();

            if(predicate =="liked")
            {
                likes = likes.Where(like => like.SourceUserId == userId);
                users = likes.Select(like => like.LikedUser);
            }
             if(predicate == "likedBy")
            {
                likes = likes.Where(like => like.LikedUserId == userId);
                users = likes.Select(like => like.SourceUser);
            }

            return await users.Select(user => new LikeDto
            {
                Username =user.UserName,
                KnownAs = user.KnownAs,
                Age=user.DateOfBirth.CalculateAge(),
                City = user.City,
                PhotoUrl = user.Photos.FirstOrDefault(p=>p.IsMain).Url,
                Id= user.Id,

            }).ToListAsync();


        }

        public async Task<AppUser> GetUserWithLikes(int UserId)
        {
            return await _context.Users.Include(x => x.LikedUsers).FirstOrDefaultAsync(x => x.Id == UserId);
        }
    }
}
