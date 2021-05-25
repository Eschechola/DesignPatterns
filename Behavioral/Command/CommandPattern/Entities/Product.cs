using System;

namespace CommandPattern.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(Guid id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Product(string name, decimal price)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine("\nId: " + Id.ToString());
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: $" + Price);
        }
    }
}
