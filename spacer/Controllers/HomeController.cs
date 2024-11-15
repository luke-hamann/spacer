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
        [Route("s/{name}")]
        public IActionResult Subspace(string name, string sort = "newest")
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
        [Route("u/{name}")]
        public new IActionResult User(string name, string section = "posts")
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();

            ViewBag.userProfile = _context.Users
                .Where(u => u.name == name)
                .FirstOrDefault();

            if (ViewBag.userProfile == null)
            {
                return NotFound();
            }

            int userId = ViewBag.userProfile.id;

            if (section == "posts")
            {
                ViewBag.selection = "posts";

                ViewBag.content = _context.Posts
                    .Include(p => p.subspace)
                    .Include(p => p.user)
                    .Where(p => p.userId == userId)
                    .OrderBy(p => p.creationDate)
                    .ToList();
            }
            else
            {
                ViewBag.selection = "comments";

                ViewBag.content = _context.Comments
                    .Include(p => p.post)
                    .Include(p => p.user)
                    .Where(p => p.userId == userId)
                    .ToList();
            }

            return View();
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
