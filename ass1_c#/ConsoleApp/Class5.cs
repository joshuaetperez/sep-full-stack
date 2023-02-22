namespace ConsoleApp
{
    public static class Class5
    {
        public static void PrintPyramid()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i) + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
