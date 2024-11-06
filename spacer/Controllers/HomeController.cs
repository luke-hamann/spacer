using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.popularSubspaces = _context.Subspaces
                .Include(s => s.posts)
                .OrderBy(s => s.posts.Count())
                .ToList();

            return View();
        }

        [HttpGet]
        [Route("/subspace/{id}/")]
        public IActionResult Subspace(int id)
        {
            ViewBag.user = _context.Users.Find(HttpContext.Session.GetInt32("userId"));

            ViewBag.subspace = _context.Subspaces.Find(id);

            if (ViewBag.subspace == null)
            {
                return NotFound();
            }

            List<Post> posts = _context.Posts
                .Include(p => p.User)
                .Include(p => p.Subspace)
                .Where(p => p.forumId == id)
                .OrderByDescending(p => p.creationDate)
                .ToList();

            return View(posts);
        }

        [HttpGet]
        [Route("/user/{id}/")]
        public IActionResult User(int id)
        {
            ViewBag.user = _context.Users.Find(HttpContext.Session.GetInt32("userId"));

            ViewBag.userProfile = _context.Users.Find(id);

            if (ViewBag.userProfile == null)
            {
                return NotFound();
            }

            ViewBag.posts = _context.Posts
                .Include(p => p.Subspace)
                .Include(p => p.User)
                .Where(p => p.userId == id)
                .OrderBy(p => p.creationDate)
                .ToList();

            return View();
        }

        [HttpGet]
        [Route("/search/")]
        public IActionResult Search([FromQuery(Name = "q")] string query = "")
        {
            ViewBag.user = _context.Users.Find(HttpContext.Session.GetInt32("userId"));

            ViewBag.query = query;

            List<Post> posts = _context.Posts
                .Include(p => p.User)
                .Include(p => p.Subspace)
                .Where(p => (p.title.Contains(query) || p.content.Contains(query)))
                .ToList();

            return View(posts);
        }
    }
}
