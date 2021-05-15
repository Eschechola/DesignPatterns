using System;

namespace BridgePattern.Fretes
{
    public class FreteSedex : IFrete
    {
        public double CalcularValorDoFrete(string cep)
        {
            return new Random().Next(0, 200) * 2.3;
        }
    }
}
