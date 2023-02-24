namespace ConsoleApp
{
    public interface IDepartmentService
    {
        bool AddCourse(Course course);
        bool RemoveCourse(Course course);
        void RemoveAllCourses();
        void PrintCourseList();

    }
}
