using BridgePattern.Fees;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Fee fee;
            string zipcode = "99999-000";

            fee = new Fee(new FeeeSedex());
            Console.WriteLine("Calculando frete via Sedex: R${0:0.00}", fee.CalculateFeePrice(zipcode));

            fee = new Fee(new FeeAzul());
            Console.WriteLine("Calculando frete via Azul: R${0:0.00}", fee.CalculateFeePrice(zipcode));

            fee = new Fee(new FeeLoggi());
            Console.WriteLine("Calculando frete via Loggi: R${0:0.00}", fee.CalculateFeePrice(zipcode));
        }
    }
}
