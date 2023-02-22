using ConsoleApp;

// Playing with Console App

Class1.GenerateHackerName();
Console.WriteLine();

// -------------------------------

// Practice number sizes and ranges

// 1)
Class2.PrintBytes();
Console.WriteLine();

// 2)
Class3.PrintConvertedCenturies(1);
Console.WriteLine();
Class3.PrintConvertedCenturies(5);
Console.WriteLine();

// -------------------------------

// Practice loops and operators

// 1)
Class4.FizzBuzz();
Console.WriteLine();

//int max = 500;
//for (byte i = 0; i < max; i++)
//{
//    WriteLine(i);
//}

// The above code gives an compiler error stating that the name 'WriteLine' does not exist in the current context.
// To warn the user about the problem, you can implement the function and throw a warning/exception, like the following:

//void WriteLine(byte i)
//{
//    throw new NotImplementedException();
//}

// 2)
Class5.PrintPyramid();
Console.WriteLine();

// 3)
Class6.GuessNumber();
Console.WriteLine();

// 4)
Console.WriteLine("What is your birthday? Please enter in format: MM/DD/YYYY");
string? dateInput = Console.ReadLine();
if (dateInput == "" || dateInput == null)
{
    Console.WriteLine("You did not enter a valid date");
}
else
{
    DateTime parsedDate = DateTime.Parse(dateInput);
    Class7.PrintDaysOld(parsedDate);
    Class7.PrintDaysToNextAnniversary(parsedDate);
}
Console.WriteLine();

// 5)
Class8.PrintGreeting();
Console.WriteLine();

// 6)
Class9.CountTo24();
Console.WriteLine();



