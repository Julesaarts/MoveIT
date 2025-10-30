using Core.Domain;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MoveIT.Models
{
    public class RideModel
    {
        //public int Id { get; private set; }

        //onderstaande is nodig om velden te connecten met de Page class
        //[Required(ErrorMessage = "Please enter the date of the ride.")]
        //public Date Date { get; set; }

        [Required]
        [Range(0, 10000)]
        [Display(Name = "Distance")]
        public int Distance { get; set; }

        [Required]
        [Range(1, 4)]
        [Display(Name = "Number of people")]
        public int NumberOfPeople { get; set; }

        [Range(0, 10000)]
        [Display(Name = "Price")]
        public int Price { get; set; }

        [Display(Name = "Ongoing")]
        public bool Ongoing { get; set; }
    }
}