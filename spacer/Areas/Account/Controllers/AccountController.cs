using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using spacer.Areas.Account.Models;
using spacer.Models;

namespace spacer.Areas.Account.Controllers
{
    [Area("Account")]
    public class AccountController : Controller
    {
        private readonly SpacerContext _context;

        public AccountController(SpacerContext context)
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
        [Route("login")]
        public IActionResult Login(string returnTo)
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();

            if (returnTo == null || returnTo == "") returnTo = "/";

            if (ViewBag.currentUser == null)
            {
                var loginForm = new LoginForm { returnTo = returnTo };
                ModelState.Clear();
                return View(loginForm);
            }
            else
            {
                return Redirect(returnTo);
            }
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginForm loginForm)
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();

            if (ViewBag.currentUser != null)
            {
                return Redirect(loginForm.returnTo!);
            }

            if (!ModelState.IsValid)
            {
                return View(loginForm);
            }

            User? user = _context.Users
                .Where(u => u.name == loginForm.identity || u.email == loginForm.identity)
                .Where(u => u.password == loginForm.password)
                .FirstOrDefault();

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid credentials.");
                return View(loginForm);
            }

            HttpContext.Session.SetInt32("userId", user.id);
            return Redirect(loginForm.returnTo!);
        }

        [HttpPost]
        [Route("logout")]
        public IActionResult Logout(string returnTo = "/")
        {
            HttpContext.Session.SetInt32("userId", 0);
            return Redirect(returnTo);
        }

        [HttpGet]
        [Route("register")]
        public IActionResult Register(string returnTo = "/")
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();

            if (ViewBag.currentUser != null)
            {
                return Redirect(returnTo);
            }

            var registerForm = new RegisterForm { returnTo = returnTo };
            ModelState.Clear();
            return View(registerForm);
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegisterForm registerForm)
        {
            ViewBag.currentUser = GetCurrentUser();
            ViewBag.popularSubspaces = GetPopularSubspaces();

            if (ViewBag.currentUser != null)
            {
                return Redirect(registerForm.returnTo!);
            }

            var user = _context.Users
                .Where(u => u.name == registerForm.name)
                .FirstOrDefault();

            if (user != null)
            {
                ModelState.AddModelError("", "That username is already taken.");
            }

            user = _context.Users
                .Where(u => u.email == registerForm.email)
                .FirstOrDefault();

            if (user != null)
            {
                ModelState.AddModelError("", "That email is already taken.");
            }

            if (!ModelState.IsValid)
            {
                return View(registerForm);
            }

            user = new User
            {
                name = registerForm.name!,
                email = registerForm.email!,
                password = registerForm.password!
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            HttpContext.Session.SetInt32("userId", user.id);
            return Redirect(registerForm.returnTo!);
        }
    }
}
