using API.DTOs;
using API.Entities;
using API.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Interfaces
{
   public interface IMessageRepository
    {

        void AddMessage(Message message);
        void DeletMessage(Message message);

        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDto>> GetMessagesForUser(MessageParams massageParams);
        Task<IEnumerable<MessageDto>> GetMessageThread(string currentUsername, string recipientUsername);
        Task<bool> SaveAllAsync();
    }
}
