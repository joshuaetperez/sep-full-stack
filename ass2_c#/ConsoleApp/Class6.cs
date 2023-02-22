namespace ConsoleApp
{
    public static class Class6
    {
        public static void PrintMostFrequentNum()
        {
            Console.WriteLine("Enter array of n integers (separated by spaces) to get most frequent number: ");
            string? input = Console.ReadLine();
            string[] stringArr = input.Split(' ');
            int[] arr = new int[stringArr.Length];
            for (int i = 0; i < stringArr.Length; i++)
            {
                arr[i] = Convert.ToInt32(stringArr[i]);
            }

            int maxCount = 0;
            int sequenceNum = -1;
            for (int l = 0; l < arr.Length; l++)
            {
                int currentCount = 1;
                for (int r = l + 1; r < arr.Length; r++)
                {
                    if (arr[l] == arr[r])
                    {
                        currentCount++;
                    }
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    sequenceNum = arr[l];
                }
            }

            Console.WriteLine($"The number {sequenceNum} is the most frequent (occurs {maxCount} times)");
        }
    }
}
