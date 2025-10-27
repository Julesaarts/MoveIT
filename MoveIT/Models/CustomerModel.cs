using System.ComponentModel.DataAnnotations;

namespace MoveIT.Models
{
    public class CustomerModel
    {
        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 3)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 10, MinimumLength = 6)]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 3)]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}

