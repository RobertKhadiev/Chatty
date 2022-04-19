using AutoMapper;
using Chatty.DataAccess.Entities;
using Chatty.Domain.Models;

namespace Chatty.Domain.MappingProfiles
{
    public class ChatProfile : Profile
    {
        public ChatProfile()
        {
            CreateMap<ChatEntity, ChatDto>();
            CreateMap<ChatDto, ChatEntity>();
        }
    }
}