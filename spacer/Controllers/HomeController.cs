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
                .OrderBy(s => s.posts.Count())
                .ToList();
        }

        public IActionResult Index()
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();

            var posts = _context.Posts
                .Include(p => p.Subspace)
                .Include(p => p.User)
                .OrderBy(s => s.creationDate).ToList();

            return View(posts);
        }

        [HttpGet]
        [Route("/subspace/{id}/")]
        public IActionResult Subspace(int id)
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();
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

  
        public IActionResult User(int id, string section="posts")
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();

            ViewBag.currentUserProfile = _context.Users.Find(id);

            if (ViewBag.currentUserProfile == null)
            {
                return NotFound();
            }

            if (section == "posts")
            {
                ViewBag.selection = "posts";

                ViewBag.content = _context.Posts
                .Include(p => p.Subspace)
                .Include(p => p.User)
                .Where(p => p.userId == id)
                .OrderBy(p => p.creationDate)
                .ToList();
            } else
            {
                ViewBag.selection = "comments";

                ViewBag.content = _context.Comments
                .Include(p => p.Post)
                .Include(p => p.User)
                .Where(p => p.userId == id)
                .ToList();
            }

  

            return View();
        }

        [HttpGet]
        [Route("/search/")]
        public IActionResult Search(
            [FromQuery(Name = "q")] string query = "",
            [FromQuery(Name = "subspaceId")] int subspaceId = 0)
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();
            ViewBag.searchQuery = query;
            ViewBag.searchSubspaceId = subspaceId;

            List<Post> posts = _context.Posts
                .Include(p => p.User)
                .Include(p => p.Subspace)
                .Where(p => (p.title.Contains(query) || p.content.Contains(query)))
                .Where(p => subspaceId == 0 || p.Subspace.id == subspaceId)
                .ToList();

            return View(posts);
        }
    }
}
