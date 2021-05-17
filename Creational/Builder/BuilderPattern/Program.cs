using BuilderPattern.Builders;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new OrderDirector();

            var simpleBuilder = new SimpleOrderBuilder();
            var simpleOrder = director.Build(simpleBuilder);

            simpleOrder.ShowOrderDetails();
            
            var fiscalBuilder = new FiscalOrderBuilder();
            var fiscalOrder = director.Build(fiscalBuilder);

            fiscalOrder.ShowOrderDetails();

            Console.ReadKey();
        }
    }
}
