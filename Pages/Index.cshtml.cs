using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using StudentsAndCourses.Models;
using StudentsAndCourses.Operations;

namespace StudentsAndCourses.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public Student student { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
              //  FirstLoad = true;
                student = Factory.GetAStudent(1);
            }
            return Page();
        }




        public void OnGet()
        {
            
        }
    }
}