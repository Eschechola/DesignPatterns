using System;

namespace BridgePattern.Fretes
{
    public class FreteLoggi : IFrete
    {
        public double CalcularValorDoFrete(string cep)
        {
            return new Random().Next(0, 200) * 1.5;
        }
    }
}
