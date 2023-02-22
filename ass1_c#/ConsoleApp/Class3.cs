using System.Diagnostics;

namespace ConsoleApp
{
    public static class Class3
    {
        public static void PrintConvertedCenturies(int numOfCenturies)
        {
            ulong numOfYears = (ulong) numOfCenturies * 100;
            ulong numOfDays = numOfYears * 365;
            ulong numOfHours = numOfDays * 24;
            ulong numOfMinutes = numOfHours * 60;
            ulong numOfSeconds = numOfMinutes * 60;
            ulong numOfMilliseconds = numOfSeconds * 1000;
            ulong numOfMicroseconds = numOfMilliseconds * 1000;
            ulong numOfNanoseconds = numOfMicroseconds * 1000;
            Console.WriteLine($"{numOfCenturies} centuries = {numOfYears} years = {numOfDays} days = {numOfHours} hours = {numOfMinutes} minutes = " +
                $"{numOfSeconds} seconds = {numOfMilliseconds} milliseconds = {numOfMicroseconds} microseconds = {numOfNanoseconds} nanoseconds");
        }
    }
}
