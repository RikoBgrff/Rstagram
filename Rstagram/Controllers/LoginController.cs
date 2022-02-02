using Microsoft.AspNetCore.Mvc;
using Rstagram.Models;
using Rstagram.Services;

namespace Rstagram.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserAuthentication authentication;

        public LoginController(IUserAuthentication authentication)
        {
            this.authentication = authentication;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (authentication.AuthenticateUser(model.Username, model.Password) == 1)
            {
            return Redirect("Home/Index");
            }
            if (authentication.AuthenticateUser(model.Username, model.Password) == 2)
            {
                return Redirect("Admin/Admin/Admin");
            }
            else return View(model);
        }
    }
}
