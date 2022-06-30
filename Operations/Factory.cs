using StudentsAndCourses.Models;

namespace StudentsAndCourses.Operations
{
    public static class Factory
    {
        //factory method that decides which Student type to instantiate
        public static Student GetAStudent(int? id)
        {
            switch (id)
            {
                case 1:
                    return new Programming();
                case 2:
                    return new Web();


                default:
                    return new Web();
            }

        }




    }
}
