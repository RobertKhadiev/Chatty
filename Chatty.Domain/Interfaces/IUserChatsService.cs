using System.Collections.Generic;
using Chatty.Domain.Models;

namespace Chatty.Domain.Interfaces
{
    public interface IUserChatsService
    {
        List<ChatDto> GetChatsByUser(long userId);
    }
}