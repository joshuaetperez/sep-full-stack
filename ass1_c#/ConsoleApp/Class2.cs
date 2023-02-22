using System;

namespace ConsoleApp
{
    public static class Class2
    {
        // Outputs the number of bytes in memory that each of the following number types uses, and the minimum and maximum values they can have:
        // sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.
        public static void PrintBytes()
        {
            Console.WriteLine("sbyte uses 1 byte of memory, has a minimum value of -128, and has a maximum value of 128");
            Console.WriteLine("byte uses 1 byte of memory, has a minimum value of 0, and has a maximum value of 255");
            Console.WriteLine("short uses 2 byte of memory, has a minimum value of -32,768, and has a maximum value of 32,767");
            Console.WriteLine("ushort uses 2 byte of memory, has a minimum value of 0, and has a maximum value of 65,535");
            Console.WriteLine("int uses 4 byte of memory, has a minimum value of -2,147,483,648, and has a maximum value of 2,147,483,647");
            Console.WriteLine("uint uses 4 byte of memory, has a minimum value of 0, and has a maximum value of 4,294,967,295");
            Console.WriteLine("long uses 8 byte of memory, has a minimum value of -9,223,372,036,854,775,808, and has a maximum value of 9,223,372,036,854,775,807");
            Console.WriteLine("ulong uses 8 byte of memory, has a minimum value of 0, and has a maximum value of 18,446,744,073,709,551,615");
            Console.WriteLine("float uses 4 byte of memory, has a minimum value of -3.4e38, and has a maximum value of 3.4e38");
            Console.WriteLine("double uses 8 byte of memory, has a minimum value of -1.7e308, and has a maximum value of 1.7e308");
            Console.WriteLine("decimal uses 16 byte of memory, has a minimum value of -7.9e28 , and has a maximum value of 7.9e28 ");
        }
    }
}
