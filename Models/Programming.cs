using StudentsAndCourses.Operations;

namespace StudentsAndCourses.Models
{
    public class Programming : Student
    {
        public bool HasLaptop { get; set; }
        public bool IsEnrolledinMSA { get; set; }

        public Programming()
        {
            StudentNZQACourses.Add(new NZQACourses("Year 1 DSD", "123", true, "2020"));
        }
    }


}
