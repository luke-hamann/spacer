using System.ComponentModel.DataAnnotations;

namespace spacer.Areas.Account.Models
{
    public class LoginForm
    {
        [Required(ErrorMessage = "Please enter a Username/Email.")]
        public string? Identity { get; set; }

        [Required(ErrorMessage = "Please enter a Password.")]
        public string? Password { get; set; }
    }
}
