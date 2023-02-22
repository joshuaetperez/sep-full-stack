namespace ConsoleApp
{
    public static class Class7
    {
        public static void printReverseString1()
        {
            Console.WriteLine("Enter a string to be printed in reverse (Method 1): ");
            string? input = Console.ReadLine();

            char[] charArr = input.ToCharArray();
            for (int i = 0; i < charArr.Length / 2; i++)
            {
                int endIndex = charArr.Length - 1 - i;
                char temp = charArr[i];
                charArr[i] = charArr[endIndex];
                charArr[endIndex] = temp;
            }
            string reversedStr = new string(charArr);
            Console.WriteLine(reversedStr);
        }

        public static void printReverseString2()
        {
            Console.WriteLine("Enter a string to be printed in reverse: (Method 2)");
            string? input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}
