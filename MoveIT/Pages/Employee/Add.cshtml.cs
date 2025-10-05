using Core.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoveIT.Models;

namespace MoveIT.Pages.Employee
{
    public class AddModel : PageModel
    {
        [BindProperty]
        public EmployeeModel Employee { get; set; } = new();
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

            EmployeeService service = new EmployeeService();
            service.AddEmployee(new Core.Domain.Employee(Employee.Name));


            return RedirectToPage("List");
        }
    }
}
