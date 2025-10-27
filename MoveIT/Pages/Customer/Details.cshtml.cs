using Core.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoveIT.Models;

namespace MoveIT.Pages.Customer
{
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public CustomerModel Customer { get; set; } = new();
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

            //CustomerService service = new CustomerService();

            //try
            //{
            //    service.AddRide(Ride.Map());
            //}
            //catch (Exception ex)
            //{
            //    ModelState.AddModelError(string.Empty, "We were unable to process your request");
            //    return Page();
            //}

            //de regel hieronder wordt vervangen door de regel hierboven (maar zeker wanneer er meer gemapt wordt, kan dat allemaal onder mapping worden geplaatst, is overzichtelijker)
            //service.AddRide(new Core.Domain.Ride(Ride.Distance, Ride.Price, Ride.Ongoing));


            return RedirectToPage("/Ride/Add");
        }
    }
}
