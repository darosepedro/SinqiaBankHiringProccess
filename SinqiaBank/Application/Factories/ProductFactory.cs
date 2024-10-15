namespace SinqiaBankHiringProccess.Application.Factories
{
    public abstract class ProductFactory
    {
        public abstract IProduct CreateProduct();
    }

    public class PhysicalProductFactory : ProductFactory
    {
        public override IProduct CreateProduct()
        {
            return new PhysicalProduct();
        }
    }

    public class DigitalProductFactory : ProductFactory
    {
        public override IProduct CreateProduct()
        {
            return new DigitalProduct();
        }
    }
}
