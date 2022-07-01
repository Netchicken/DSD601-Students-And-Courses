using StudentsAndCourses.Models;
using StudentsAndCourses.Operations;

namespace StudentsAndCourses.Interfaces
{
    public interface IStudent
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        DateTime DOB { get; set; }
        Course Course { get; set; }
        List<string> StudentHardware { get; set; }
        List<string> MainTransportType { get; set; }
        List<NZQACourses> StudentNZQACourses { get; set; }
        int StudentSelected { get; set; }
    }
}