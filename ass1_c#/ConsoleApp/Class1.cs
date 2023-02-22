namespace ConsoleApp
{
    public static class Class1
    {
        public static void GenerateHackerName()
        {
            Console.WriteLine("Enter your favorite color: ");
            string? favColor = Console.ReadLine();

            Console.WriteLine("Enter your favorite astrology sign: ");
            string? favSign = Console.ReadLine();

            Console.WriteLine("Enter your street address number: ");
            string? addressNum = Console.ReadLine();

            Console.WriteLine($"Your hacker name is {favColor}{favSign}{addressNum}");
        }
    }
}
