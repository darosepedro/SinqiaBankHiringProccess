using SinqiaBankHiringProccess.Core.Validators;

namespace SinqiaBankHiringProccess.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUserValidator _userValidator;

        public OrderService(IUserValidator userValidator)
        {
            _userValidator = userValidator;
        }

        public void PlaceOrder(string username, string productName)
        {
            if (!_userValidator.ValidateUser(username, "senha123"))
            {
                throw new Exception("Usuário inválido.");
            }
        }
    }

}
