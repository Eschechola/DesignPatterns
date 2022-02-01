namespace BridgePattern.Fees
{
    public interface IFeeType
    {
        double CalculateFeePrice(string zipcode);
    }
}
