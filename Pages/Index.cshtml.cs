using Microsoft.AspNetCore.Mvc.RazorPages;

using StudentsAndCourses.Models;

namespace StudentsAndCourses.Pages
{
    public class IndexModel : PageModel
    {
        public Programming programming { get; set; }


        public void OnGet()
        {
            //   programming.Course.
        }
    }
}