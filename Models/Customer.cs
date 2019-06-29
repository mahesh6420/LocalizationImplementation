using System.ComponentModel.DataAnnotations;

namespace Localization.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "{0} is required.")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }
    }
}