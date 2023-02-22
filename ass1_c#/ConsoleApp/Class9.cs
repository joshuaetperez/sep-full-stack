namespace ConsoleApp
{
    public static class Class9
    {
        public static void CountTo24()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 0; j <= 24; j += i)
                {
                    if (j != 0)
                    {
                        Console.Write(",");
                    }
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
