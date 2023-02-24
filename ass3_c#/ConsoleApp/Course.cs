using System.Xml.Linq;

namespace ConsoleApp
{
    public class Course : ICourseService
    {
        public string Name { get; set; }
        public List<Student> EnrolledStudents { get; set; } = new List<Student>();

        public Course(string name) {
            Name = name;
        }

        public bool AddToEnrollment(Student student)
        {
            if (EnrolledStudents.Contains(student))
            {
                return false;
            }
            EnrolledStudents.Add(student);
            return true;
        }

        public bool RemoveFromEnrollment(Student student)
        {
            if (EnrolledStudents.Contains(student))
            {
                EnrolledStudents.Remove(student);
                return true;
            }
            return false;
        }

        public void RemoveAllFromEnrollment()
        {
            EnrolledStudents.Clear();
        }

        public void PrintEnrollmentList()
        {
            for (int i = 0; i < EnrolledStudents.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(EnrolledStudents[i].Name);
            }
            Console.WriteLine();
        }
    }
}
