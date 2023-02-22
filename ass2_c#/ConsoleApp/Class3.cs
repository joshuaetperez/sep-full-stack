using System;

namespace ConsoleApp
{
    public static class Class3
    {
        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
            int arrLength = 0;
            for (int i = startNum; i <= endNum; i++)
            {
                if (i == 2)
                {
                    arrLength++;
                    continue;
                }
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    if (j == i - 1)
                    {
                        arrLength++;
                    }
                }
            }

            int[] primeNumbersInRange = new int[arrLength];
            int currentIndex = 0;
            for (int i = startNum; i <= endNum; i++)
            {
                if (i == 2)
                {
                    primeNumbersInRange[currentIndex] = i;
                    currentIndex++;
                    continue;
                }
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                    if (j == i - 1)
                    {
                        primeNumbersInRange[currentIndex] = i;
                        currentIndex++;
                    }
                }
            }
            return primeNumbersInRange;
        }
    }
}
