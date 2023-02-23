using System.Text;

namespace ConsoleApp
{
    public static class Class8
    {
        public static void printReverseSentence()
        {
            Console.WriteLine("Enter sentence to reverse: ");
            string? input = Console.ReadLine();
            string[] punctuationArr = input.Split(new Char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', '#', ' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] wordsArr = input.Split(new Char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' '});
            string[] strippedWordsArr = input.Split(new Char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' '}, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder reverseSentence = new StringBuilder();
            int punctuationIndex = 0;
            int strippedWordsIndex = strippedWordsArr.Length - 1;
            for (int i = 0; i < wordsArr.Length; i++)
            {
                if (String.IsNullOrEmpty(wordsArr[i]) && punctuationIndex < punctuationArr.Length)
                {
                    reverseSentence.Append(punctuationArr[punctuationIndex]);
                    punctuationIndex++;
                }
                else if (strippedWordsIndex >= 0)
                {
                    if (i != 0 && i != wordsArr.Length - 1)
                    {
                        reverseSentence.Append(" ");
                    }
                    reverseSentence.Append(strippedWordsArr[strippedWordsIndex]);
                    strippedWordsIndex--;
                }
            }

            Console.WriteLine(reverseSentence.ToString());
        }
    }
}
