namespace SinqiaBankHiringProccess.Core.Validators
{
    public class UserValidator : IUserValidator
    {
        public bool ValidateUser(string username, string password)
        {
            // Exemplo de validação simples
            return !string.IsNullOrEmpty(username) && password.Length >= 6;
        }
    }
}
