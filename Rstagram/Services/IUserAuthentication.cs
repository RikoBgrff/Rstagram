namespace Rstagram.Services
{
    public interface IUserAuthentication
    {
        int AuthenticateUser(string username, string password);
    }
}
