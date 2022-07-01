namespace StudentsAndCourses.Interfaces
{
    public interface IStudent
    {
        string? FirstName { get; set; }
        string? LastName { get; set; }

        // Course Course { get; set; }
        List<string> StudentHardware { get; set; }
        List<string> MainTransportType { get; set; }
        //  List<NZQACourses> StudentNZQACourses { get; set; }
        int? StudentSelected { get; set; }
    }
}