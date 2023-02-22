namespace ConsoleApp
{
    public static class Class8
    {
        public static void PrintGreeting()
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime.Hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (currentTime.Hour < 18)
            {
                Console.WriteLine("Good Afternoon");
            }
            else if (currentTime.Hour < 21)
            {
                Console.WriteLine("Good Evening");
            }
            else
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}
