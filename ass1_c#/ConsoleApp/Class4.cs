using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class Class4
    {
        public static void FizzBuzz()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
            }
        }
    }
}
