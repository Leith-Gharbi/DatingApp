using API.DTOs;
using API.Entities;
using API.Helpers;
using API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class MessageRepository : IMessageRepository
    {
        private readonly DataDbContext _context;

        public MessageRepository(DataDbContext context)
        {
            _context = context;
        }
        public void AddMessage(Message message)
        {
            _context.Messages.Add(message);
        }

        public void DeletMessage(Message message)
        {
            _context.Messages.Remove(message);
        }

        public async Task<Message> GetMessage(int id)
        {
            return await _context.Messages.FindAsync(id);
                }

        public Task<PagedList<MessageDto>> GetMessagesForUser()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MessageDto>> GetMessageThread(int currentUserId, int recipientId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;   
        }
    }
}
