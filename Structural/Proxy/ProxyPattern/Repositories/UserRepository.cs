using System;
using System.Collections.Generic;
using ProxyPattern.Modelos;

namespace ProxyPattern.Repositories
{
    public class UserRepository : IUserRepository
    {
        public static IList<User> Users = null;

        public void Show()
        {
            foreach (var user in Users)
            {
                Console.WriteLine("");
                Console.WriteLine($"Id: {user.Id}");
                Console.WriteLine($"Nome: {user.Name}");
                Console.WriteLine($"Email: {user.Email}");
            }
        } 

        public void Load()
        {
            Users = new List<User>
            {
                new User { Id = 1, Name = "Lucas", Email = "lucas@eu.com" },
                new User { Id = 2, Name = "Gabriel", Email = "gabriel@eu.com"},
                new User { Id = 3, Name = "Matheus", Email = "matheus@eu.com" },
            };
        }
    }
}
