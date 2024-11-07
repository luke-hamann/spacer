using System.ComponentModel.DataAnnotations;

namespace spacer.Areas.Account.Models
{
    public class RegisterForm
    {
        [Required]
        public string? name { get; set; }

        [Required]
        public string? email { get; set; }

        [Required]
        public string? password { get; set; }

        [Required]
        public string? passwordConfirm { get; set; }

        [Required]
        public string? returnTo { get; set; } = "/";
    }
}
