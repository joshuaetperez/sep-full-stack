namespace ConsoleApp
{
    public static class Class1
    {
        public static void CopyingAnArray()
        {
            int[] values1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] values2 = new int[values1.Length];
            for (int i = 0; i < values1.Length; i++)
            {
                values2[i] = values1[i];
            }

            Console.Write($"The original array contains the values: ");
            for (int i = 0; i < values1.Length; i++)
            {
                if (i != 0)
                {
                    Console.Write(", ");
                }
                Console.Write(values1[i]);
            }
            Console.WriteLine();


            Console.Write($"The copied array contains the values: ");
            for (int i = 0; i < values2.Length; i++)
            {
                if (i != 0)
                {
                    Console.Write(", ");
                }
                Console.Write(values2[i]);
            }
            Console.WriteLine();
        }
    }
}
