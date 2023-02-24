namespace ConsoleApp
{
    public static class Class2
    {
        public static int FibonacciHelper(int val)
        {
            if (val == 1 || val == 2)
            {
                return 1;
            }
            return FibonacciHelper(val - 2) + FibonacciHelper(val - 1);
        }
        public static void PrintFibonacci(int val)
        {
            Console.WriteLine(FibonacciHelper(val));
        }
    }
}
