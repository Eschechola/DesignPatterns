using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new OrderCalculator(5, 10);

            var dolarCalculator = new DolarOrderCalculator(calculator, 5.3);
            Console.WriteLine("Order price in dolar: {0} dolars", dolarCalculator.CalculatePrice());

            var euroCalculator = new EuroOrderCalculator(calculator, 6.4);
            Console.WriteLine("Order price in euro: {0} euros", euroCalculator.CalculatePrice());

            Console.ReadKey();
        }
    }
}
