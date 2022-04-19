using System.Collections.Generic;

namespace Chatty.DataAccess.Entities
{
    public class ChatEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ChatType Type { get; set; }
        
        public List<MessageEntity> Messages { get; set; }
    }

    public enum ChatType
    {
        Personal = 1,
        Group
    }
}