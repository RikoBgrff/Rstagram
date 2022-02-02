using Microsoft.AspNetCore.Mvc;
using Rstagram.DB;
using Rstagram.Entities;

namespace Rstagram.Controllers
{
    public class SuperUserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SuperUserController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, ActionName("Create")]
        public IActionResult CreatePOST(SuperUser superUser)
        {
            _context.SuperUsers.Add(superUser);
            _context.SaveChanges();
            return RedirectToAction(nameof(Create));
        }
    }
}
