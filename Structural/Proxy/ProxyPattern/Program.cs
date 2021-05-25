using System;
using ProxyPattern.Repositories;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserRepository userProxy = new UserProxy();

            //create's a instance
            userProxy.Show();

            //use a existent instance
            userProxy.Show();

            Console.ReadKey();
        }
    }
}
