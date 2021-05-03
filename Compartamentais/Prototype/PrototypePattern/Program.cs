using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product(
                Guid.NewGuid(),
                "GTX 1050 TI",
                2000M,
                10);

            product.ShowDetails();

            //Shallow Clone
            var productShallowClone = (Product)product.ShallowClone();
            productShallowClone.Name = "GTX 1060";
            productShallowClone.Price = 3000M;

            productShallowClone.ShowDetails();

            //Deep Clone
            var productDeepClone = (Product)product.DeepClone();
            productDeepClone.Name = "GTX 1070 TI";

            productDeepClone.ShowDetails();
        }
    }
}
