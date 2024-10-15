namespace SinqiaBankHiringProccess.Core.Validators
{
    public interface IUserValidator
    {
        bool ValidateUser(string username, string password);
    }

}
