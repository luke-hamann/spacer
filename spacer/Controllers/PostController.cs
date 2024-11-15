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
                .OrderByDescending(s => s.posts.Count())
                .ToList();
        }

        [HttpGet]
        [Route("s/{subspaceName}/post/{id}")]
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
        [Route("add")]
        public IActionResult Add(int subspaceId = 0)
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();

            if (ViewBag.currentUser == null)
            {
                return RedirectToRoute(new { area = "Account", controller = "Account", action = "Login", returnTo = "/add" });
            }

            var post = new Post();

            if (subspaceId > 0)
            {
                post.forumId = subspaceId;
            }

            return View(post);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Post post)
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();

            if (ViewBag.currentUser == null)
            {
                return RedirectToRoute(new { area = "Account", controller = "Account", action = "Login" , returnTo = "/add" });
            }

            Subspace? subspace = _context.Subspaces.Find(post.forumId);

            if (subspace == null)
            {
                ModelState.AddModelError("", "That subspace does not exist.");
            }

            if (!ModelState.IsValid)
            {
                return View(post);
            }

            post.creationDate = DateTime.Now;

            _context.Add(post);
            _context.SaveChanges();

            return RedirectToAction("Index", "Post", new { post.id, subspaceName = subspace!.name });
        }

        [HttpPost]
        [Route("comment")]
        public IActionResult Comment(int postId, string content)
        {
            // Verify the user is logged in
            User? currentUser = GetCurrentUser();
            if (currentUser == null)
            {
                return RedirectToRoute(new { area = "Account", controller = "Account", action = "Login" });
            }

            // Ensure the post exists
            Post? post = _context.Posts
                .Include(p => p.Subspace)
                .Where(p => p.id == postId)
                .FirstOrDefault();

            if (post == null)
            {
                return RedirectToAction("Index", "Home");
            }


            // Ensure content was submitted
            if (content == null || content == "")
            {
                return RedirectToAction("Index", "Post", new { post.id, subspaceName = post.Subspace!.name });
            }

            // Save the comment
            var comment = new Comment
            {
                userId = currentUser.id,
                postId = postId,
                content = content,
                creationDate = DateTime.Now
            };

            _context.Add(comment);
            _context.SaveChanges();

            return RedirectToAction("Index", "Post", new { post.id, subspaceName = post.Subspace!.name });
        }
    }
}
