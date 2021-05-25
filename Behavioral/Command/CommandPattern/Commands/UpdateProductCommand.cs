using CommandPattern.Entities;
using System.Linq;

namespace CommandPattern.Commands
{
    public class UpdateProductCommand : OrderCommand
    {
        public override void Execute(Order order, Product product)
        {
            var oldProduct = order.Products.Where(x => x.Id == product.Id)
                .FirstOrDefault();

            order.Products.Remove(oldProduct);
            order.Products.Add(product);
        }
    }
}
