using Core.Domain;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MoveIT.Models.RideModel
{
    public class VehicleModel
    {
        //public int Id { get; private set; }

        //onderstaande is nodig om velden te connecten met de Page class
        //[Required(ErrorMessage = "Please enter the date of the ride.")]
        //public Date Date { get; set; }

        [Required]
        [Range(0, 10000)]
        [Display(Name = "Distance")]
        public int Distance { get; set; }

        [Range(0, 10000)]
        [Display(Name = "Price")]
        public int Price { get; set; }
    }
}