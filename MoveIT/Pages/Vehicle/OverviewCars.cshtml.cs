using Core.Domain.Services;
using Core.Domain.Vehicles;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Core.Domain.Vehicles;

namespace MoveIT.Pages.Vehicle
{
    public class OverviewCarsModel : PageModel
    {
        [BindProperty]
        public IReadOnlyList<Core.Domain.Vehicles.Vehicle> Vehicles { get; private set; } = [];

        public void OnGet()
        {
            VehicleService vehicleService = new();
            this.Vehicles = vehicleService.GetVehicles();
        }
    }
}
