namespace BridgePattern.Fees
{
    public class Fee
    {
        IFeeType _fee;

        public Fee(IFeeType frete)
        {
            _fee = frete;
        }

        public double CalculateFeePrice(string cep)
            => _fee.CalculateFeePrice(cep);
    }
}
