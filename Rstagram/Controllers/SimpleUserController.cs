using Microsoft.AspNetCore.Mvc;
using Rstagram.DB;
using Rstagram.Entities;

namespace Rstagram.Controllers
{
    public class SimpleUserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SimpleUserController(ApplicationDbContext context)
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
        public IActionResult CreatePOST(SimpleUser simpleUser)
        {
            _context.SimpleUsers.Add(simpleUser);
            _context.SaveChanges();
            return RedirectToAction(nameof(Create));
        }
    }
}
