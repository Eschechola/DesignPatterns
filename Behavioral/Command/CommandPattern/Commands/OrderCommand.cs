using CommandPattern.Entities;

namespace CommandPattern.Commands
{
    public abstract class OrderCommand
    {
        public abstract void Execute(Order order, Product product);
    }
}
