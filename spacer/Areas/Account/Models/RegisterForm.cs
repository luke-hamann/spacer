using System.ComponentModel.DataAnnotations;

namespace spacer.Areas.Account.Models
{
    public class RegisterForm
    {
        [Required(ErrorMessage = "Please enter a username.")]
        public string? name { get; set; }

        [Required(ErrorMessage = "Please enter an email.")]
        [EmailAddress]
        public string? email { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(255, ErrorMessage = "Password must be at least 8 characters.", MinimumLength = 8)]
        public string? password { get; set; }

        [Required(ErrorMessage = "Please confirm your password.")]
        [Compare("password", ErrorMessage = "Passwords do not match.")]
        public string? passwordConfirm { get; set; }

        [Required]
        public string? returnTo { get; set; } = "/";
    }
}
