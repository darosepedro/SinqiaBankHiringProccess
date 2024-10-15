using Microsoft.AspNetCore.Mvc;
using SinqiaBankHiringProccess.Core.Validators;

namespace SinqiaBankHiringProccess.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase // , IObserver
    {
        private readonly IUserValidator _userValidator;

        // Injeção de dependência do validador
        public UserController(IUserValidator userValidator)
        {
            _userValidator = userValidator;
        }

        [HttpPost("create")]
        public IActionResult CreateUser()
        {
            return Ok("Usuário criado com sucesso!");
        }

        [HttpPost("validate")]
        public IActionResult ValidateUser([FromBody] UserCredentials credentials)
        {
            // Valida o usuário
            bool isValid = _userValidator.ValidateUser(credentials.Username, credentials.Password);

            if (isValid)
                return Ok(new { Message = "Usuário válido!" });

            return BadRequest(new { Message = "Credenciais inválidas." });
        }
    }

    // Classe para receber as credenciais via Body da requisição
    public class UserCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}