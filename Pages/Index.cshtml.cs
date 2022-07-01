using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using StudentsAndCourses.Models;
using StudentsAndCourses.Operations;

namespace StudentsAndCourses.Pages
{

    public class IndexModel : PageModel
    {
        [BindProperty]
        public Student? student { get; set; }
        [BindProperty]
        public bool FirstLoad { get; set; } = false;
        [BindProperty]
        public string? ErrorMessage { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {

            if (ModelState.IsValid)
            {
                FirstLoad = true;
                //here we are changing the studnet class to the selected class.
                student = Factory.GetAStudent(student.StudentSelected);
            }
            else
            {
                var message = string.Join(" | ", ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage));

                ErrorMessage = message;
            }
            return Page();
        }


        public IndexModel()
        {
            //student = new Student();
        }

        public void OnGet()
        {



        }
    }
}