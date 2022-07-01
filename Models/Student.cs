using StudentsAndCourses.Interfaces;
using StudentsAndCourses.Operations;

namespace StudentsAndCourses.Models
{
    public class Student : IStudent
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public Course Course { get; set; }
        public List<string> StudentHardware { get; set; }
        public List<string> MainTransportType { get; set; }
        public List<NZQACourses> StudentNZQACourses { get; set; }
        public int StudentSelected { get; set; }
        public Student()
        {
            StudentHardware = new List<string>();
            MainTransportType = new List<string>();
            StudentNZQACourses = new List<NZQACourses>();
            Course = new Course();


            MainTransportType.Add("Car");
            MainTransportType.Add("Bus");
            MainTransportType.Add("Cycle");
            MainTransportType.Add("Walk");

        }
    }


}


