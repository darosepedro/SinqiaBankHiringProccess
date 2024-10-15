namespace SinqiaBankHiringProccess.Application.Factories
{
    public class PhysicalProduct : IProduct
    {
        public string GetDetails()
        {
            return "Produto Físico - Envio pelos Correios.";
        }
    }
}
