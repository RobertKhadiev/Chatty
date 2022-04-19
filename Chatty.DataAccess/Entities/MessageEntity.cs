namespace Chatty.DataAccess.Entities
{
    public class MessageEntity : BaseEntity
    {
        public string Text { get; set; }
        public long? ChatId { get; set; }
        public ChatEntity Chat { get; set; }
        public long? UserId { get; set; }
        public UserEntity User { get; set; }
    }
}