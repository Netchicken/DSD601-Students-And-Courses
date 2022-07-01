namespace StudentsAndCourses.Models
{
    public class Programming : Student
    {


        public bool HasLaptop { get; set; } = true;
        public bool IsEnrolledinMSA { get; set; }


        public Programming()
        {
            FirstName = "Susan";
            LastName = "Kwan";
            // Course = new Course();
            Course.Name = "Programming";
            Course.Tutor = "Gary";
        }
    }


}
