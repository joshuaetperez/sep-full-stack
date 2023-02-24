namespace ConsoleApp
{
    public class Instructor : Person, IInstructorService
    {
        public string Department { get; set; }
        public DateTime JoinDate { get; set; }

        public Instructor(string name, int age, double salary, string department, DateTime joinDate) : base(name, age, salary)
        {
            Department = department;
            JoinDate = joinDate;
        }

        public double CalculateExperience()
        {
            return (DateTime.Now - JoinDate).Days / 365;
        }
    }
}
