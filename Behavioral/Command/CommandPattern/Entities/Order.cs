using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandPattern.Entities
{
    public class Order
    {
        public Guid Id { get; set; }

        public double Price
        {
            get => (double) Products.Sum(x => x.Price);
            private set { }
        }

        public IList<Product> Products { get; set; }
        public object Where { get; internal set; }

        public Order()
        {
            Id = Guid.NewGuid();
            Products = new List<Product>();
        }

        public void ShowCurrentItems()
        {
            foreach (var product in Products)
                product.Display();

            Console.WriteLine("\n\nTOTAL ORDER PRICE: $" + Price);
            Console.WriteLine("-----------------------");
        }
    }
}
