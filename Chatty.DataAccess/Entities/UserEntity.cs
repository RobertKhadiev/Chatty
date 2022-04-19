using System;
using System.Collections.Generic;

namespace Chatty.DataAccess.Entities
{
    public class UserEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime? BirthDate { get; set; }
        
        public List<MessageEntity> Messages { get; set; }
    }
}