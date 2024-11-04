using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using spacer.Models;

namespace spacer.Controllers
{
    public class PostController : Controller
    {
        private readonly SpacerContext _context;

        public PostController(SpacerContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/post/{id}/")]
        public IActionResult Index(int id)
        {
            ViewBag.user = _context.Users.Find(HttpContext.Session.GetInt32("userId"));

            ViewBag.post = _context.Posts
                .Include(p => p.User)
                .Include(p => p.Subspace)
                .Where(p => p.id == id)
                .FirstOrDefault();

            if (ViewBag.post == null)
            {
                return NotFound();
            }

            ViewBag.comments = _context.Comments
                .Include(c => c.User)
                .Where(c => c.postId == id)
                .OrderBy(c => c.creationDate)
                .ToList();

            return View();
        }

        [HttpGet]
        [Route("/new/")]
        public IActionResult New()
        {
            ViewBag.user = _context.Users.Find(HttpContext.Session.GetInt32("userId"));

            if (ViewBag.user == null)
            {
                return RedirectToRoute(new { area = "Account", controller = "Account", action = "Login" });
            }

            var post = new Post();
            return View(post);
        }
    }
}
