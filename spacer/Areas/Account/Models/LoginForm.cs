using System.ComponentModel.DataAnnotations;

namespace spacer.Areas.Account.Models
{
    public class LoginForm
    {
        [Required]
        public string? Identity { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
