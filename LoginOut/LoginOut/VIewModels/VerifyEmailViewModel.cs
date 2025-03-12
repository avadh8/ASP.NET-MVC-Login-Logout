using System.ComponentModel.DataAnnotations;

namespace LoginOut.VIewModels
{
    public class VerifyEmailViewModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
    }
}
