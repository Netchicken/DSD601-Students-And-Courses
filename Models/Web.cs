namespace StudentsAndCourses.Models
{
    public class Web : Student
    {
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; } = "Smith";
        public bool HasPhotoShop { get; set; } = true;
        public Course Course { get; set; }

        public Web()
        {
            Course.Name = "Web";
            Course.Tutor = "Jeffery";
        }

    }

}
