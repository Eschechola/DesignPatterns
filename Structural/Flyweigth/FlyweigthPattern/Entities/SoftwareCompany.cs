using System;
using System.Collections.Generic;

namespace FlyweigthPattern.Entities
{
    public class SoftwareCompany : Company
    {
        public List<string> Softwares { get; private set; }
        public int SoftwaresCount { get => Softwares.Count; private set { } }

        public SoftwareCompany()
        {
            Name = "CH Labs";
            CustomersCount = 12;
            Softwares = new List<string>
            {
                "CH Fact",
                "CH Marketplace"
            };
        }

        public override void Description()
        {
            Console.WriteLine("Company name: " + Name);
            Console.WriteLine("Customers count: " + CustomersCount);
            Console.WriteLine("Softwares count: " + SoftwaresCount);
            Console.WriteLine("Softwares: " + string.Join(", ", Softwares));
        }
    }
}
