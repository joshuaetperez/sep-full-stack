using System;

namespace ConsoleApp
{
    public static class Class7
    {
        public static void PrintDaysOld(DateTime birthday)
        {
            Console.WriteLine($"You are {(DateTime.Today - birthday).Days} days old");
        }

        public static void PrintDaysToNextAnniversary(DateTime birthday)
        {
            int daysToAnniversary = 10000 - ((DateTime.Today - birthday).Days % 10000);
            Console.WriteLine($"Your next 10,000 day anniversary is {DateTime.Today.AddDays(daysToAnniversary)}");
        }
    }
}
