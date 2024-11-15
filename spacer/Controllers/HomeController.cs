using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [NonAction]
        private User? GetCurrentUser()
        {
            return _context.Users.Find(HttpContext.Session.GetInt32("userId"));
        }

        [NonAction]
        private List<Subspace> GetPopularSubspaces()
        {
            return _context.Subspaces
                .Include(s => s.posts)
                .OrderByDescending(s => s.posts.Count())
                .ToList();
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();

            List<Post> posts = _context.Posts
                .Include(p => p.subspace)
                .Include(p => p.user)
                .OrderByDescending(s => s.creationDate)
                .ToList();

            return View(posts);
        }

        [HttpGet]
        [Route("s/{name}/{sort?}")]
        public IActionResult Subspace(string name, string sort)
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();

            ViewBag.subspace = _context.Subspaces
                .Where(s => s.name == name)
                .FirstOrDefault();

            if (ViewBag.subspace == null)
            {
                return NotFound();
            }

            if (sort == null || sort == "") sort = "newest";

            if (sort != "oldest" && sort != "newest")
            {
                return NotFound();
            }

            int subspaceId = ViewBag.subspace.id;
            ViewBag.searchSubspaceId = subspaceId;

            var query = _context.Posts
                .Include(p => p.user)
                .Include(p => p.subspace)
                .Where(p => p.subspace!.id == subspaceId);
            
            if (sort == "newest")
            {
                query = query.OrderByDescending(p => p.creationDate);
            }
            else
            {
                query = query.OrderBy(p => p.creationDate);
            }

            List<Post> posts = query.ToList();

            return View(posts);
        }

        [HttpGet]
        [Route("u/{name}/{section?}")]
        public new IActionResult User(string name, string section)
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();

            User? user = _context.Users
                .Where(u => u.name == name)
                .FirstOrDefault();

            if (user == null) return NotFound();

            if (section == null || section == "" || section == "posts")
            {
                ViewBag.section = "posts";
                user.posts = _context.Posts
                    .Include(p => p.user)
                    .Include(p => p.subspace)
                    .Where(p => p.userId == user.id)
                    .OrderByDescending(p => p.creationDate)
                    .ToList();
            }
            else if (section == "comments")
            {
                ViewBag.section = "comments";
                user.comments = _context.Comments
                    .Include(c => c.user)
                    .Include(c => c.post)
                    .Where(c => c.userId == user.id)
                    .OrderByDescending(c => c.creationDate)
                    .ToList();
            }
            else
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpGet]
        [Route("search")]
        public IActionResult Search(string query = "", int subspaceId = 0)
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();

            ViewBag.searchQuery = query;
            ViewBag.searchSubspaceId = subspaceId;

            List<Post> posts = _context.Posts
                .Include(p => p.user)
                .Include(p => p.subspace)
                .Where(p => (query == null || p.title.Contains(query) || p.content.Contains(query)))
                .Where(p => (subspaceId == 0 || p.subspace!.id == subspaceId))
                .OrderByDescending(p => p.creationDate)
                .ToList();

            return View(posts);
        }
    }
}
