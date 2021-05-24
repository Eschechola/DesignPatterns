namespace DecoratorPattern
{
    public class DolarOrderCalculator : ICalculator
    {
        private readonly ICalculator _calculator;
        private readonly double _dolarQuotation;

        public DolarOrderCalculator(ICalculator calculator, double dolarQuotation)
        {
            _calculator = calculator;
            _dolarQuotation = dolarQuotation;
        }

        public double CalculatePrice()
        {
            return _calculator.CalculatePrice() * _dolarQuotation;
        }
    }
}
