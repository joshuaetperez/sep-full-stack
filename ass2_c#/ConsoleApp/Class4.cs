using System;

namespace ConsoleApp
{
    public static class Class4
    {
        public static int[] GetRotatedSumArray()
        {
            Console.WriteLine("Enter array of n integers (separated by spaces) to get rotated sum array: ");
            string? input = Console.ReadLine();
            string[] stringArr = input.Split(' ');
            int[] arr = new int[stringArr.Length];
            int[] sumArray = new int[stringArr.Length];
            for (int i = 0; i < stringArr.Length; i++)
            {
                arr[i] = Convert.ToInt32(stringArr[i]);
                sumArray[i] = 0;
            }

            Console.WriteLine("Enter number of rotations: ");
            int k = Convert.ToInt32(Console.ReadLine());

            for (int r = 1; r <= k; r++)
            {
                for (int l = 0; l < arr.Length; l++) {
                    int newPosition = (l + r) % arr.Length;
                    sumArray[newPosition] += arr[l];
                }
            }
            return sumArray;
        }
    }
}
