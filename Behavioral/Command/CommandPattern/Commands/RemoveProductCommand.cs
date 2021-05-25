using CommandPattern.Entities;

namespace CommandPattern.Commands
{
    public class RemoveProductCommand : OrderCommand
    {
        public override void Execute(Order order, Product product)
        {
            order.Products.Remove(product);
        }
    }
}
