namespace Chatty.DataAccess.Entities
{
    public class UserChatsEntity : BaseEntity
    {
        public long? ChatId { get; set; }
        public ChatEntity Chat { get; set; }
        
        public long? UserId { get; set; }
        public UserEntity User { get; set; }
    }
}