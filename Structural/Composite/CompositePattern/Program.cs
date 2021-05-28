using CompositePattern.Items;
using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Root("Root directory");

            var group1 = new Group("Developers");
            var group2 = new Group("Analysts");

            var user1 = new User("Lucas");
            var user2 = new User("Gabriel");
            var user3 = new User("Paulo");
            var user4 = new User("Maria");

            var device1 = new Device("MacBook pro 2017");
            var device2 = new Device("Iphone XS 128GB");
            var device3 = new Device("iPad 8 128GB");
            var device4 = new Device("Asus Ultrabook 2019");
            var device5 = new Device("Asus Rog Phone");
            var device6 = new Device("Dell G3 3590");
            var device7 = new Device("Dell Latitude 5490");

            // User 1
            user1.AddChildren(device1);
            user1.AddChildren(device2);
            user1.AddChildren(device3);

            // User 2
            user2.AddChildren(device4);

            // User 3
            user3.AddChildren(device5);
            user3.AddChildren(device6);

            // User 4
            user4.AddChildren(device7);

            // Group 1
            group1.AddChildren(user1);
            group1.AddChildren(user2);

            // Group 2
            group2.AddChildren(user3);
            group2.AddChildren(user4);

            // Root
            root.AddChildren(group1);
            root.AddChildren(group2);

            root.Display();

            Console.ReadKey();
        }
    }
}
