using System.ComponentModel.DataAnnotations;

namespace spacer.Areas.Account.Models
{
    public class LoginForm
    {
        [Required]
        public string? identity { get; set; }

        [Required]
        public string? password { get; set; }

        [Required]
        public string? returnTo { get; set; } = "/";
    }
}
