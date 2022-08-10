using StudentsAndCourses.Interfaces;

namespace StudentsAndCourses.Models
{
    public class Student : IStudent
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public Course? Course { get; set; }
        public List<string> StudentHardware { get; set; }
        public List<string> MainTransportType { get; set; }
        public int? StudentSelected { get; set; }
        public Student()
        {
            Course = new Course();
            StudentHardware = new List<string>();
            MainTransportType = new List<string>();
            MainTransportType.Add("Car");
            MainTransportType.Add("Bus");
            MainTransportType.Add("Cycle");
            MainTransportType.Add("Walk");

        }
    }


}


