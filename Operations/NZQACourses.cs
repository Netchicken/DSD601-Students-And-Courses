namespace StudentsAndCourses.Operations
{
    public class NZQACourses
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public bool HasPassed { get; set; }
        public string YearCompleted { get; set; }

        public NZQACourses(string name, string number, bool hasPassed, string yearCompleted)
        {
            Name = name;
            Number = number;
            HasPassed = hasPassed;
            YearCompleted = yearCompleted;
        }
    }
}
