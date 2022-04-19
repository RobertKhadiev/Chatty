using Chatty.DataAccess.Entities;

namespace Chatty.Domain.Models
{
    public class ChatDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ChatType Type { get; set; }
    }
}