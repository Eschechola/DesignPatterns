using System;
using System.Collections.Generic;

namespace FlyweigthPattern.Entities
{
    public class FoodCompany : Company
    {
        public List<string> BestSandwiches { get; private set; }

        public FoodCompany()
        {
            Name = "MC Donald's";
            CustomersCount = 2000000;
            BestSandwiches = new List<string>
            {
                "Big Mac",
                "Big Tasty",
                "CBO"
            };
        }

        public override void Description()
        {
            Console.WriteLine("Company name: " + Name);
            Console.WriteLine("Customers count: " + CustomersCount);
            Console.WriteLine("And the best sandwiches: " + string.Join(", ", BestSandwiches));
        }
    }
}
