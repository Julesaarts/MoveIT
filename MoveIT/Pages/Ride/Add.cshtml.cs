using Core.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoveIT.Helpers.Mappers;
using MoveIT.Models;

namespace MoveIT.Pages.Ride
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public RideModel Ride { get; set; } = new();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            //als model state niet valid is, dan returnen naar original page (en show errors)
            if (!ModelState.IsValid)
            {
                return Page();
            }

            RideService service = new RideService();


            service.AddRide(Ride.Map());
            //de regel hieronder wordt vervangen door de regel hierboven (maar zeker wanneer er meer gemapt wordt, kan dat allemaal onder mapping worden geplaatst, is overzichtelijker)
            //service.AddRide(new Core.Domain.Ride(Ride.Distance, Ride.Price, Ride.Ongoing));


            return RedirectToPage("List");
        }
    }
}
