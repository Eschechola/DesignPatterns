using System;

namespace BuilderPattern.Builders
{
    public class FiscalOrderBuilder : IBuilder
    {
        public double CalculatePrice()
        {
            return new Random().NextDouble() * 2000;
        }

        public string GetProductName()
        {
            return "Big Product";
        }

        public string GetProductType()
        {
            return "Big";
        }
    }
}
