namespace BuilderPattern.Builders
{
    public interface IBuilder
    {
        string GetProductName();
        string GetProductType();
        double CalculatePrice();
    }
}
