using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using StudentsAndCourses.Models;
using StudentsAndCourses.Operations;

namespace StudentsAndCourses.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        //this is the student base class
        public Student? student { get; set; }

        public void OnGet()
        {

            student = new Student();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                //here we are changing the studnet class to the selected class.
                student = Factory.GetAStudent(student.StudentSelected);
            }
            return Page();
        }
    }
}