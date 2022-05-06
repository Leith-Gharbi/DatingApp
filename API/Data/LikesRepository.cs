using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
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
        public Task<UserLike> GetUserLike(int sourceUserId, int likeUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LikeDto>> GetUserLikes(string predicate, int userId)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetUserWithLikes(int UserId)
        {
            throw new NotImplementedException();
        }
    }
}
