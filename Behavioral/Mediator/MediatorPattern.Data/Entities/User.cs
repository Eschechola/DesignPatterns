using System;

namespace MediatorPattern.Data.Entities
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public User(){}

        public User(string name, string email)
        {
            Id = new Random().Next(99999);
            Name = name;
            Email = email;
        }

        public User(long id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}
