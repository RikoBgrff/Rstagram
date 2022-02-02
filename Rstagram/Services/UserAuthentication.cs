using Rstagram.DB;

namespace Rstagram.Services
{
    public class UserAuthentication : IUserAuthentication
    {
        private readonly ApplicationDbContext context;

        public UserAuthentication(ApplicationDbContext context)
        {
            this.context = context;
        }

        public int AuthenticateUser(string username, string password)
        {
            foreach (var item in context.Users)
            {
                if (item.Username == username && item.Password == password && item.Discriminator == "SimpleUser")
                {
                    return 1;
                }
                else if (item.Username == username && item.Password == password && item.Discriminator == "SuperUser")
                {
                    return 2;
                }
            }
            return 0;
        }
    }
}