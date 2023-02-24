namespace ConsoleApp
{
    public class Department : IDepartmentService
    {
        public string Name { get; set; }
        public Instructor HeadInstructor { get; set; }
        public int Budget { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public List<Course> Courses { get; } = new List<Course>();

        public Department(string name, Instructor headInstructor, int budget, DateTime startDateTime, DateTime endDateTime)
        {
            Name = name;
            HeadInstructor = headInstructor;
            Budget = budget;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
        }


        public bool AddCourse(Course course)
        {
            if (Courses.Contains(course))
            {
                return false;
            }
            Courses.Add(course);
            return true;
        }

        public bool RemoveCourse(Course course)
        {
            if (Courses.Contains(course))
            {
                Courses.Remove(course);
                return true;
            }
            return false;
        }

        public void RemoveAllCourses()
        {
            Courses.Clear();
        }

        public void PrintCourseList()
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(Courses[i].Name);
            }
            Console.WriteLine();
        }
    }
}
