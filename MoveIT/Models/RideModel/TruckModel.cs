using MoveIT.Models.RideModel;
using System.ComponentModel.DataAnnotations;

namespace MoveIT.Models.RideModel
{
    public class TruckModel : VehicleModel
    {
        [Required]
        [Range(1, 5000)]
        [Display(Name = "Package Weight")]
        public int PackageWeight { get; set; }

        [Required]
        [Range(1, 1000)]
        [Display(Name = "Package Volume")]
        public int PackageVolume { get; set; }
    }
}