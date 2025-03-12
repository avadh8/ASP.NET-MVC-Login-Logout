using System.ComponentModel.DataAnnotations;

namespace LoginOut.VIewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [StringLength(40,MinimumLength =8,ErrorMessage ="The {0} must be at {2} and at max {1} character")]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Password and Confirm Password must be same")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password is required")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

    }
}
