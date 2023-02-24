namespace ConsoleApp
{
    public interface IStudentService : IPersonService
    {
        bool AddCourse(string name, char grade);
        bool RemoveCourse(string name);
        void RemoveAllCourses();
        void PrintCourses();
        double CalculateGPA();

    }
}
