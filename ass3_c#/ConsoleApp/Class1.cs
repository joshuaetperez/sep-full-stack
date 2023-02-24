namespace ConsoleApp
{
    public static class Class1
    {
        public static int[] GenerateNumbers(int length)
        {
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = i + 1;
            }
            return numbers;
        }

        public static void Reverse(int[] numbers)
        {
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int temp = numbers[i];
                int endIndex = numbers.Length - i - 1;
                numbers[i] = numbers[endIndex];
                numbers[endIndex] = temp;
            }
        }

        public static void PrintNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i != 0)
                {
                    Console.Write(", ");
                }
                Console.Write(numbers[i]);
            }
            Console.WriteLine();
        }
    }
}
