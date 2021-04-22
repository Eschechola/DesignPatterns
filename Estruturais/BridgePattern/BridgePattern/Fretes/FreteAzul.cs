using System;

namespace BridgePattern.Fretes
{
    public class FreteAzul : IFrete
    {
        public double CalcularValorDoFrete(string cep)
        {
            return new Random().Next(0, 200) * 2;
        }
    }
}
