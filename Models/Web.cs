namespace StudentsAndCourses.Models
{
    public class Web : Student
    {

        public bool HasPhotoShop { get; set; } = true;
        //public Course Course { get; set; }

        public Web()
        {
            FirstName = "John";
            LastName = "Smith";
            //Course = new Course();
            Course.Name = "Web";
            Course.Tutor = "Jeffery";
        }

    }

}
