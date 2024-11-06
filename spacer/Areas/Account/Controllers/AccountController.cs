using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        [Route("Login")]
        public IActionResult Login()
        {
            User? user = GetCurrentUser();

            if (user == null)
            {
                return View();
            }
            else
            {
                return Redirect("/");
            }
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginForm loginForm)
        {
            if (GetCurrentUser() != null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (!ModelState.IsValid)
            {
                return View(loginForm);
            }

            User? user = _context.Users
                .Where(u => u.name == loginForm.Identity || u.email == loginForm.Identity)
                .Where(u => u.password == loginForm.Password)
                .FirstOrDefault();

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid credentials.");
                return View(loginForm);
            }
            else
            {
                HttpContext.Session.SetInt32("userId", user.id);
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.SetInt32("userId", 0);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Route("Register")]
        public IActionResult Register()
        {
            if (GetCurrentUser() != null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterForm registerForm)
        {
            if (GetCurrentUser() != null)
            {
                return RedirectToAction("Index", "Home");
            }

            if (registerForm.password != registerForm.passwordConfirm)
            {
                ModelState.AddModelError("", "Passwords must match.");
            }

            var user = _context.Users.Where(u => u.name == registerForm.name).FirstOrDefault();
            if (user != null)
            {
                ModelState.AddModelError("", "That username is already taken.");
            }

            user = _context.Users.Where(u => u.email == registerForm.email).FirstOrDefault();
            if (user != null)
            {
                ModelState.AddModelError("", "That email is already taken.");
            }

            if (!ModelState.IsValid)
            {
                return View(registerForm);
            }

            user = new User { name = registerForm.name, email = registerForm.email, password = registerForm.password };

            _context.Users.Add(user);
            _context.SaveChanges();

            HttpContext.Session.SetInt32("userId", user.id);
            return RedirectToAction("Index", "Home");
        }


    }
}
