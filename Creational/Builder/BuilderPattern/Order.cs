using System;

namespace BuilderPattern
{
    public class Order
    {
        public Guid Id { get; private set; }
        public string ProductName { get; private set; }
        public string ProductType { get; private set; }
        public double Price { get; private set; }

        public Order(string productName, string productType, double price)
        {
            Id = Guid.NewGuid();
            ProductName = productName;
            ProductType = productType;
            Price = price;
        }

        public void ShowOrderDetails()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Showing order details...");
            Console.WriteLine("ID: {0}", Id.ToString());
            Console.WriteLine("Product Name: {0}", ProductName);
            Console.WriteLine("Product Type: {0}", ProductType);
            Console.WriteLine("Order Price: {0:0.00}", Price);
            Console.WriteLine("---------------------------------------");
        }
    }
}
