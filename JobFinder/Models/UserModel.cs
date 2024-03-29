using System.ComponentModel.DataAnnotations;

namespace JobFinder.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string UserEmail { get; set; }
        [Required(ErrorMessage = "Firstname is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lastname is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
        [Compare("UserPassword", ErrorMessage = "The password and confirmation password do not match.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
