using System.ComponentModel.DataAnnotations;

namespace spacer.Areas.Account.Models
{
    public class LoginForm
    {
        [Required(ErrorMessage = "Please enter your username or email.")]
        public string? identity { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        public string? password { get; set; }

        [Required]
        public string? returnTo { get; set; } = "/";
    }
}
