using System.Diagnostics;

namespace ConsoleApp
{
    public class Student : Person, IStudentService
    {
        List<string> Courses = new List<string>();
        List<char> CourseGrades = new List<char>();

        public Student(string name, int age, double salary) : base(name, age, salary)
        {

        }
        public bool AddCourse(string name, char grade)
        {
            if (Courses.Contains(name))
            {
                return false;
            }
            if ((new[] {'A', 'B', 'C', 'D', 'E', 'F'}).Contains(grade))
            {
                Courses.Add(name);
                CourseGrades.Add(grade);
                return true;
            }
            return false;
        }
        public bool RemoveCourse(string name)
        {
            int deletionIndex = Courses.IndexOf(name);
            if (deletionIndex > -1)
            {
                Courses.RemoveAt(deletionIndex);
                CourseGrades.RemoveAt(deletionIndex);
                return true;
            }
            return false;
        }
        public void RemoveAllCourses()
        {
            Courses.Clear();
            CourseGrades.Clear();
        }
        public double CalculateGPA()
        {
            char[] gradeLetters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F' };
            double[] gradeValues = new double[] { 0.0, 0.0, 1.0, 2.0, 3.0, 4.0 };

            double gpa = 0.0;
            for (int i = 0; i < CourseGrades.Count; i++)
            {
                gpa += gradeValues[Array.IndexOf(gradeLetters, CourseGrades[i])];
            }
            return gpa / CourseGrades.Count;
        }
        public void PrintCourses()
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(Courses[i]);
            }
            Console.WriteLine();
        }
    }
}
