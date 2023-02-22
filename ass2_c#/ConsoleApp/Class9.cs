namespace ConsoleApp
{
    public static class Class9
    {
        static Boolean isPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        } 

        public static void printUniquePalindromes()
        {
            Console.WriteLine("Enter text to extract unique palindromes: ");
            string? input = Console.ReadLine();
            string[] stringArr = input.Split(new Char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' },  StringSplitOptions.RemoveEmptyEntries);
            string[] distStringArr = stringArr.Distinct().ToArray();

            int numOfPalindromes = 0;
            for (int i = 0; i < distStringArr.Length; i++)
            {
                if (isPalindrome(distStringArr[i]))
                {
                    numOfPalindromes++;
                }
            }

            string[] palindromeArr = new string[numOfPalindromes];
            numOfPalindromes = 0;
            for (int i = 0; i < distStringArr.Length; i++)
            {
                if (isPalindrome(distStringArr[i]))
                {
                    palindromeArr[numOfPalindromes] = distStringArr[i];
                    numOfPalindromes++;
                }
            }

            Array.Sort(palindromeArr);
            for (int i = 0; i < numOfPalindromes; i++)
            {
                if (i != 0)
                {
                    Console.Write(", ");
                }
                Console.Write(palindromeArr[i]);
            }
            Console.WriteLine();
        }
    }
}
