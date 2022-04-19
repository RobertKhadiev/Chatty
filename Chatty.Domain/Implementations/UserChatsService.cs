using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Chatty.DataAccess;
using Chatty.Domain.Interfaces;
using Chatty.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Chatty.Domain.Implementations
{
    public class UserChatsService : IUserChatsService
    {
        private readonly ChattyDbContext _context;
        private readonly IMapper _mapper;

        public UserChatsService(ChattyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<ChatDto> GetChatsByUser(long userId)
        {
            var chats = _context.UserChats
                .Include(x => x.Chat)
                .Where(x => x.UserId == userId)
                .Select(x => x.Chat)
                .ToList();

            var chatsDto = _mapper.Map<List<ChatDto>>(chats);
            
            return chatsDto;
        }
    }
}