﻿namespace ConsoleApp
{
    public static class Class8
    {
        public static void printReverseSentence()
        {
            Console.WriteLine("Enter sentence to reverse: ");
            string? input = Console.ReadLine();
            //Console.WriteLine(String.Join(" ", input.Split(new Char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', '#'}, StringSplitOptions.RemoveEmptyEntries)).ToString());
            Console.WriteLine(String.Join(" ", input.Split(new Char[] { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }).Reverse()).ToString());
        }
    }
}
