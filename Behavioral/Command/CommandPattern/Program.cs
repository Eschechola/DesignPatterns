using CommandPattern.Commands;
using CommandPattern.Entities;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoker = new OrderInvoker();

            invoker.SetCommand(new AddProductCommand());
            invoker.SetProduct(new Product("RTX 3070", 7000));
            invoker.ExecuteCommand();

            invoker.SetCommand(new AddProductCommand());
            invoker.SetProduct(new Product("RTX 3070 TI", 9000));
            invoker.ExecuteCommand();

            var idUpdate = Guid.NewGuid();
            invoker.SetCommand(new AddProductCommand());
            invoker.SetProduct(new Product(idUpdate, "RTX 3080 TI", 1500));
            invoker.ExecuteCommand();

            var idDelete = Guid.NewGuid();
            invoker.SetCommand(new AddProductCommand());
            invoker.SetProduct(new Product(idDelete, "RTX 3090", 24000));
            invoker.ExecuteCommand();

            invoker.SetCommand(new RemoveProductCommand());
            invoker.SetProduct(invoker.GetOrderProduct(idDelete));
            invoker.ExecuteCommand();

            var productUpdate = invoker.GetOrderProduct(idUpdate);
            productUpdate.Name = "RTX 3080";
            invoker.SetCommand(new UpdateProductCommand());
            invoker.SetProduct(productUpdate);
            invoker.ExecuteCommand();

            invoker.ShowOrderDetails();

            Console.ReadKey();
        }
    }
}
