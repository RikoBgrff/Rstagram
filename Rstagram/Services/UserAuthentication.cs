using Rstagram.DB;

namespace Rstagram.Services
{
    public class UserAuthentication
    {
        public ApplicationDbContext context { get; set; }

        public bool AuthenticateUser(string username, string password)
        {
            foreach (var item in context.Users)
            {
                if (item.Username != username && item.Password != password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}