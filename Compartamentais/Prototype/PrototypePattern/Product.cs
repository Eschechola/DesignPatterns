using System;

namespace PrototypePattern
{
    public class Product : IPrototype
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public Product(Guid id, string name, decimal price, int amount)
        {
            Id = id;
            Name = name;
            Price = price;
            Amount = amount;
        }

        public IPrototype ShallowClone()
        {
            return (Product)this.MemberwiseClone();
        }

        public IPrototype DeepClone()
        {
            var product = new Product(
                this.Id,
                String.Copy(this.Name),
                this.Price,
                this.Amount);

            return (Product)product;
        }

        public void ShowDetails()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Show products details:");
            Console.WriteLine("Id: " + this.Id.ToString());
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Price: $" + this.Price);
            Console.WriteLine("Amount: " + this.Amount +"un.");
            Console.WriteLine("-------------------------------------");
        }
    }
}
