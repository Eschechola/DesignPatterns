using System;

namespace BuilderPattern.Builders
{
    public class SimpleOrderBuilder : IBuilder
    {
        public double CalculatePrice()
        {
            return new Random().NextDouble() * 1000;
        }

        public string GetProductName()
        {
            return "Simple Product";
        }

        public string GetProductType()
        {
            return "Simple";
        }
    }
}
