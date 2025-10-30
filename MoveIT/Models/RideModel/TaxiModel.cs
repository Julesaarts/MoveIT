using MoveIT.Models.RideModel;
using System.ComponentModel.DataAnnotations;

namespace MoveIT.Models.RideModel
{
    public class TaxiModel : VehicleModel
    {
        [Required]
        [Range(1, 4)]
        [Display(Name = "Number of people")]
        public int Persons { get; set; }
    }
}
