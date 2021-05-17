using BuilderPattern.Builders;

namespace BuilderPattern
{
    public class OrderDirector
    {
        public Order Build(IBuilder builder)
        {
            return new Order(
                productName: builder.GetProductName(),
                productType: builder.GetProductType(),
                price: builder.CalculatePrice());
        }
    }
}
