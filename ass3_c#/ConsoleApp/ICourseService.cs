namespace ConsoleApp
{
    public interface ICourseService
    {
        bool AddToEnrollment(Student student);
        bool RemoveFromEnrollment(Student student);
        void RemoveAllFromEnrollment();
        void PrintEnrollmentList();
    }
}
