using CommandPattern.Entities;

namespace CommandPattern.Commands
{
    public class AddProductCommand : OrderCommand
    {
        public override void Execute(Order order, Product product)
        {
            order.Products.Add(product);
        }
    }
}
