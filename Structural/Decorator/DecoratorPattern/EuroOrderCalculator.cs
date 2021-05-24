namespace DecoratorPattern
{
    public class EuroOrderCalculator : ICalculator
    {
        private readonly ICalculator _calculator;
        private readonly double _euroQuotation;

        public EuroOrderCalculator(ICalculator calculator, double euroQuotation)
        {
            _calculator = calculator;
            _euroQuotation = euroQuotation;
        }

        public double CalculatePrice()
        {
            return _calculator.CalculatePrice() * _euroQuotation;
        }
    }
}
