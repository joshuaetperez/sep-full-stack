using System.Text;

namespace ConsoleApp
{
    public static class Class6
    {
        public static int findLeftMostElement(int[] arr, List<int> highestFrequencyList)
        {
            int leftMostIndex = arr.Length;
            for (int i = 0; i < highestFrequencyList.Count; i++)
            {
                int currentIndex = Array.IndexOf(arr, highestFrequencyList[i]);
                if (currentIndex < leftMostIndex)
                {
                    leftMostIndex = currentIndex;
                }
            }
            return arr[leftMostIndex];
        }
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

            int[] sortedArr = (int[]) arr.Clone();
            Array.Sort(sortedArr);

            int maxCount = 0;
            List<int> highestFrequencyList = new List<int>();
            int index = 0;
            while (index < sortedArr.Length)
            {
                int currentCount = 1;
                while (index < sortedArr.Length - 1 && sortedArr[index] == sortedArr[index + 1])
                {
                    currentCount++;
                    index++;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    highestFrequencyList.Clear();
                    highestFrequencyList.Add(sortedArr[index]);
                }
                else if (currentCount == maxCount)
                {
                    highestFrequencyList.Add(sortedArr[index]);
                }
                index++;
            }

            if (highestFrequencyList.Count == 1)
            {
                Console.WriteLine($"The number {highestFrequencyList[0]} is the most frequent (occurs {maxCount} times)");
            }
            else
            {
                int leftMostElement = findLeftMostElement(arr, highestFrequencyList); 
                StringBuilder output = new StringBuilder("The numbers ");
                for (int i = 0; i < highestFrequencyList.Count; i++) { 
                    if (i != highestFrequencyList.Count - 1)
                    {
                        output.Append($"{highestFrequencyList[i]}, ");
                    }
                    else
                    {
                        output.Append($"and {highestFrequencyList[i]} have the same maximal frequency (each occurs {maxCount} times). The leftmost is {leftMostElement}.");
                    }
                }
                Console.WriteLine(output.ToString());
            }
        }
    }
}
