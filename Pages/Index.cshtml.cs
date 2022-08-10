using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using StudentsAndCourses.Models;
using StudentsAndCourses.Operations;

namespace StudentsAndCourses.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public Student? student { get; set; }
        public bool IsFirstLoad { get; set; } = false;
        public string? ErrorMessage { get; set; }

        public IndexModel()
        {
            student = new Student();
        }

        public void OnGet()
        {
            //  student = new Student();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                IsFirstLoad = true;
                //here we are changing the student class to the selected class.
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

    }
}