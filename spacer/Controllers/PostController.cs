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

        [HttpGet]
        [Route("/post/{id}/")]
        public IActionResult Index(int id)
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();

            Post? post = _context.Posts
                .Include(p => p.User)
                .Include(p => p.Subspace)
                .Where(p => p.id == id)
                .FirstOrDefault();

            if (post == null)
            {
                return NotFound();
            }

            ViewBag.comments = _context.Comments
                .Include(c => c.User)
                .Where(c => c.postId == id)
                .OrderBy(c => c.creationDate)
                .ToList();

            return View(post);
        }

        [HttpGet]
        [Route("/new/")]
        public IActionResult New()
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();

            if (ViewBag.user == null)
            {
                return RedirectToRoute(new { area = "Account", controller = "Account", action = "Login" });
            }

            var post = new Post();
            return View(post);
        }

        [HttpPost]
        public IActionResult Comment(int postId, string content)
        {
            User? currentUser = GetCurrentUser();

            if (currentUser == null)
            {
                return RedirectToRoute(new { area = "Account", controller = "Account", action = "Login" });
            }

            var comment = new Comment
            {
                userId = currentUser.id,
                postId = postId,
                content = content,
                creationDate = DateTime.Now
            };

            _context.Add(comment);
            _context.SaveChanges();

            return RedirectToAction("Index", "Post", new { id = postId });
            
        }
    }
}
