using Core.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoveIT.Models;

namespace MoveIT.Pages.Ride
{
    public class ListModel : PageModel
    {
        [BindProperty]
        public IReadOnlyList<Core.Domain.Ride> Rides { get; private set; } = [];
        public void OnGet()
        {
            RideService rideService = new();
            this.Rides = rideService.GetRides();
        }
    }
}
