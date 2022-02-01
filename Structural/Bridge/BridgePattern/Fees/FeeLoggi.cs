using System;

namespace BridgePattern.Fees
{
    public class FeeLoggi : IFeeType
    {
        public double CalculateFeePrice(string cep)
            => new Random().Next(0, 200) * 1.5;
    }
}
