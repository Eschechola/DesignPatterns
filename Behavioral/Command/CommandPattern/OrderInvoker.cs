using CommandPattern.Commands;
using CommandPattern.Entities;
using System;
using System.Linq;

namespace CommandPattern
{
    public class OrderInvoker
    {
        private OrderCommand _command;
        private Order _order;
        private Product _product;

        public OrderInvoker()
        {
            _order = new Order();
        }

        public void SetCommand(OrderCommand command)
            => _command = command;

        public void SetProduct(Product product)
            => _product = product;

        public void ExecuteCommand()
            => _command.Execute(_order, _product);

        public void ShowOrderDetails()
            => _order.ShowCurrentItems();

        public Product GetOrderProduct(Guid id)
            => _order.Products.Where(x => x.Id == id).FirstOrDefault();
    }
}
