using Chatty.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Chatty.DataAccess
{
    public class ChattyDbContext : DbContext
    {
        public ChattyDbContext(DbContextOptions<ChattyDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ChatEntity> Chats { get; set; }
        public DbSet<MessageEntity> Messages { get; set; }
        
        public DbSet<UserChatsEntity> UserChats { get; set; }
    }
}