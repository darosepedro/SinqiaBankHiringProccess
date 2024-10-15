using Microsoft.AspNetCore.Mvc;
using SinqiaBankHiringProccess.Application.Factories;
using SinqiaBankHiringProccess.Infrasturucture;

namespace SinqiaBankHiringProccess.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        //public void Update(string message)
        //{
        //    Console.WriteLine($"[Product] Notificação recebida: {message}");
        //}

        [HttpGet("create/{type}")]
        public IActionResult CreateProduct(string type)
        {
            ProductFactory factory;

            // Usando o Factory Method para criar o tipo de produto
            if (type.ToLower() == "digital")
            {
                factory = new DigitalProductFactory();
            }
            else if (type.ToLower() == "physical")
            {
                factory = new PhysicalProductFactory();
            }
            else
            {
                return BadRequest("Tipo de produto inválido.");
            }

            var product = factory.CreateProduct();
            var productDetails = product.GetDetails();

            // Acessando a configuração global pelo Singleton
            var config = SinqiaConfigurationManager.Instance.AppConfig;

            return Ok(new
            {
                ProductDetails = productDetails,
                Configuration = config
            });
        }
    }

}