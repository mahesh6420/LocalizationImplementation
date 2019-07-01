using System.ComponentModel.DataAnnotations;

namespace Localization.ViewModels
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [EmailAddress(ErrorMessage = "The Email field is not a valid email address.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please Enter a valid Phone Number.")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Address")]
        public string Address { get; set; }
    }
}