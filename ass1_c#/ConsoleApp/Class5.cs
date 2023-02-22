namespace ConsoleApp
{
    public static class Class5
    {
        public static void PrintPyramid()
        {
            Console.WriteLine("Enter number of rows for pyramid: ");
            int numOfRows = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfRows; i++)
            {
                for (int j = 0; j < numOfRows - i - 1; j++)
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
