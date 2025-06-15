using System.ComponentModel.DataAnnotations;

namespace MultiStepForm.Web.ViewModels.Customer
{
    public class PersonalInfoViewModel
    {
        [Required]
        [StringLength(3, ErrorMessage = "Name must be at least 3 characters in length")]
        public string? Name { get; set; }

        [Required]
        [RegularExpression(@"^([a-z\d\.-]+)@([a-z\d-]+)\.([a-z]{2,4})$", ErrorMessage = "Email is invalid format")]
        public string? Email {  get; set; }

        [Required]
        [RegularExpression(@"\(\d{3}\) \d{3}-\d{4}", ErrorMessage = "Phone number must match the pattern: (NNN) NNN-NNNN")]
        [Display(Name = "Phone Number")]
        public string? PhoneNumber { get; set; }
    }
}
