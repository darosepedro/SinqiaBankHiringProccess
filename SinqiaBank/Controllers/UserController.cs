using Microsoft.AspNetCore.Mvc;
using SinqiaBankHiringProccess.Core.Validators;

namespace SinqiaBankHiringProccess.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase // , IObserver
    {
        private readonly IUserValidator _userValidator;

        // Inje��o de depend�ncia do validador
        public UserController(IUserValidator userValidator)
        {
            _userValidator = userValidator;
        }

        [HttpPost("create")]
        public IActionResult CreateUser()
        {
            return Ok("Usu�rio criado com sucesso!");
        }

        [HttpPost("validate")]
        public IActionResult ValidateUser([FromBody] UserCredentials credentials)
        {
            // Valida o usu�rio
            bool isValid = _userValidator.ValidateUser(credentials.Username, credentials.Password);

            if (isValid)
                return Ok(new { Message = "Usu�rio v�lido!" });

            return BadRequest(new { Message = "Credenciais inv�lidas." });
        }
    }

    // Classe para receber as credenciais via Body da requisi��o
    public class UserCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}