using System;
using FacadePattern.Facade;
using FacadePattern.Entities;
using System.Collections.Generic;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            FacadeClass facade = new FacadeClass();

            //lista de usuários que serão analisados
            var listOfUsers = new List<User>
            {
                new User { Id = 0, Name = "Lucas", Age = 19, Gender = 'M' },
                new User { Id = 1, Name = "Gabriel", Age = 16, Gender = 'M' },
                new User { Id = 2, Name = "Mariana", Age = 19, Gender = 'F' }
            };


            foreach (var user in listOfUsers)
            {
                Console.WriteLine("\n\nAnalisando usuário: " + user.Name);
                var userNeedAlistment = facade.UserNeedAlistment(user);
            }

            Console.ReadKey();
        }
    }
}
