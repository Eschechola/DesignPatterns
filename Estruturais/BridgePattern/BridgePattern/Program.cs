using BridgePattern.Fretes;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Frete frete;
            string cep = "99999-000";

            frete = new Frete(new FreteSedex());
            Console.WriteLine("Calculando frete via Sedex: R${0:0.00}", frete.CalcularValorDoFrete(cep));

            frete = new Frete(new FreteAzul());
            Console.WriteLine("Calculando frete via Azul: R${0:0.00}", frete.CalcularValorDoFrete(cep));

            frete = new Frete(new FreteLoggi());
            Console.WriteLine("Calculando frete via Loggi: R${0:0.00}", frete.CalcularValorDoFrete(cep));
        }
    }
}
