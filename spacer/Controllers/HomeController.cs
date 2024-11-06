using Microsoft.AspNetCore.Mvc;
using spacer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

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
            var posts = _context.Posts.Include(p => p.Comments).OrderBy(s => s.creationDate).ToList();
            return View(posts);
        }

        public IActionResult Search()
        {

            return View("SearchPage");

        }

    }
}
