using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatorPattern.Data.Entities;

namespace MediatorPattern.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> Users;

        public UserRepository()
        {
            Users = new List<User>
            {
                new User("Lucas", "lucas@eu.com"),
                new User("Gabriel", "gabriel@eu.com")
            };
        }

        public async Task<User> Create(User user)
        {
            await Task.Run(() =>
            {
                Users.Add(user);
            });
            
            return user;
        }

        public async Task<User> Update(User user)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < Users.Count; i++)
                {
                    if (Users[i].Id == user.Id)
                    {
                        Users[i].Name = user.Name;
                        Users[i].Email = user.Email;
                    }
                }
            });

            return user;
        }

        public async Task<User> GetByEmail(string email)
        {
            User user = new User();

            await Task.Run(() => 
            {
                user = Users.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
            });

            return user;
        }

        public async Task<User> GetById(long id)
        {
            User user = new User();

            await Task.Run(() =>
            {
                user = Users.Where(x => x.Id == id).FirstOrDefault();
            });

            return user;
        }
    }
}
