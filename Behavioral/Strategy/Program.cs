using System;
using Strategy.Currencys;
using Strategy.Interfaces;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            ICurrency currency;
            double valueToCalculate;
            double calculatedValue;

            currency = new Dollar();
            valueToCalculate = 5;
            calculatedValue = currency.CalculateBRLQuote(valueToCalculate);

            Console.WriteLine("{0} dolares = {1} reais", valueToCalculate, calculatedValue);

            currency = new Euro();
            valueToCalculate = 10;
            calculatedValue = currency.CalculateBRLQuote(valueToCalculate);

            Console.WriteLine("{0} Euros = {1} reais", valueToCalculate, calculatedValue);

            currency = new Libra();
            valueToCalculate = 20;
            calculatedValue = currency.CalculateBRLQuote(valueToCalculate);

            Console.WriteLine("{0} Libras = {1} reais", valueToCalculate, calculatedValue);

            Console.ReadKey();
        }
    }
}
