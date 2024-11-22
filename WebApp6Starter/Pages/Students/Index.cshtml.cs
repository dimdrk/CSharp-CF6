using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp6Starter.DTO;

namespace WebApp6Starter.Pages.Students
{
    public class IndexModel : PageModel
    {
        [BindProperty]  // Two-way binding
        public InsertStudentDTO InsertStudentDTO { get; set; } = new();

        public void OnGet()
        {
        }
    }
}
