using ConsoleApp;

// Working with methods

// 1)
int[] numbers = Class1.GenerateNumbers(10);
Class1.Reverse(numbers);
Class1.PrintNumbers(numbers);
Console.WriteLine();

// 2)
for (int i = 1; i <= 10; i++)
{
    Class2.PrintFibonacci(i);
}
Console.WriteLine();

// ---------------------

// Designing and Building Classes using object-oriented principles

// 1 - 6) Classes have been implemented
Student student = new Student("Jake", 18, 0.0);
student.AddAddress("12345 Street");
Course course1 = new Course("Computer Science 101");
Course course2 = new Course("US History 101");
Course course3 = new Course("Math 101");
student.AddCourse("Computer Science 101", 'A');
student.AddCourse("US History 101", 'B');
student.AddCourse("Math 101", 'C');
course1.AddToEnrollment(student);
course2.AddToEnrollment(student);
course3.AddToEnrollment(student);

Console.Write($"Student {student.Name} lives in the following addresses: ");
student.PrintAddresses();
Console.Write($"Student {student.Name} is taking the following classes: ");
student.PrintCourses();
Console.Write($"Course {course1.Name} has students: ");
course1.PrintEnrollmentList();
Console.Write($"Course {course2.Name} has students: ");
course1.PrintEnrollmentList();
Console.Write($"Course {course3.Name} has students: ");
course1.PrintEnrollmentList();

Console.WriteLine();

Instructor instructor = new Instructor("Bob", 30, 75000, "Computer Science", DateTime.Now.AddYears(-5));
Department department = new Department("Computer Science", instructor, 150000, DateTime.Now.AddMonths(-6), DateTime.Now.AddMonths(6));

Course course4 = new Course("Computer Science 102");
Course course5 = new Course("Computer Science 103");
department.AddCourse(course1);
department.AddCourse(course4);
department.AddCourse(course5);

Console.WriteLine($"Instructor {instructor.Name} is part of the {instructor.Department} department");
Console.WriteLine($"Instructor {instructor.Name} has {instructor.CalculateExperience()} years of experience");
Console.WriteLine($"The {department.Name} department has {department.HeadInstructor.Name} as the head instructor");
Console.Write($"The {department.Name} department offers the following classes: ");
department.PrintCourseList();

Console.WriteLine();

// 7)
Color yellow = new Color(255, 255, 0, 0);
Ball ball = new Ball(5.0, yellow);

Console.WriteLine("Ball throwing in progress...");
for (int i = 0; i < 5; i++)
{
    ball.Throw();
}
Console.WriteLine($"Ball has been thrown {ball.GetTimesThrown()} times!");
ball.Pop();
Console.WriteLine("Ball has been popped!");
Console.WriteLine("Trying to throw popped ball...");
ball.Pop();
Console.WriteLine($"Ball has been thrown {ball.GetTimesThrown()} times!");

