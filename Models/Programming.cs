namespace StudentsAndCourses.Models
{
    public class Programming : Student
    {
        public string FirstName { get; set; } = "Susan";
        public string LastName { get; set; } = "Smith";
        public bool HasLaptop { get; set; } = true;
        public bool IsEnrolledinMSA { get; set; }
        public Course Course { get; set; }

        public Programming()
        {
            Course.Name = "Programming";
            Course.Tutor = "Gary";
        }
    }


}
