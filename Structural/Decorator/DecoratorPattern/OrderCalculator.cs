namespace DecoratorPattern
{
    public class OrderCalculator : ICalculator
    {
        public double Price { get; private set; }
        public double Quantity { get; private set; }

        public OrderCalculator(double price, double quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        public double CalculatePrice()
        {
            return Price * Quantity;
        }
    }
}
