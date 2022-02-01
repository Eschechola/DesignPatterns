using System;

namespace BridgePattern.Fees
{
    public class FeeAzul : IFeeType
    {
        public double CalculateFeePrice(string cep)
            => new Random().Next(0, 200) * 2.1;
    }
}
