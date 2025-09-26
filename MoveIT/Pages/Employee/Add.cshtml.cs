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

        public void OnPost()
        {
        }
    }
}
