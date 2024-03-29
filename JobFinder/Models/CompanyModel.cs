using System.ComponentModel.DataAnnotations;

namespace JobFinder.Models
{
    public class CompanyModel
    {
        [Key]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string CompanyEmail { get; set; }
        [Required(ErrorMessage = "Firstname is required")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string CompanyPassword { get; set; }
        [Compare("CompanyPassword", ErrorMessage = "The password and confirmation password do not match.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}
