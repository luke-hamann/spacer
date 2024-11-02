using Microsoft.AspNetCore.Mvc;
using spacer.Models;

namespace spacer.Controllers
{
    public class HomeController : Controller
    {
        private readonly SpacerContext _context;

        public HomeController(SpacerContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.user = _context.Users.Find(HttpContext.Session.GetInt32("userId"));

            return View();
        }
    }
}
