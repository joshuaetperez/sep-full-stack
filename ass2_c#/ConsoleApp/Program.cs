using ConsoleApp;

// Practice Arrays 

// 1)
Class1.CopyingAnArray();
Console.WriteLine();

// 2)
Class2.ManageToDoList();
Console.WriteLine();

// 3)
int[] primeNumbersInRange = Class3.FindPrimesInRange(1, 100);
for (int i = 0; i < primeNumbersInRange.Length; i++)
{
    if (i != 0)
    {
        Console.Write(", ");
    }
    Console.Write(primeNumbersInRange[i]);
}
Console.WriteLine();
Console.WriteLine();

// 4)
int[] sumArray = Class4.GetRotatedSumArray();
for (int i = 0; i < sumArray.Length; i++)
{
    if (i != 0)
    {
        Console.Write(", ");
    }
    Console.Write(sumArray[i]);
}
Console.WriteLine();
Console.WriteLine();

// 5)
Class5.PrintLongestEqualSequence();
Console.WriteLine();

// 6)
Class6.PrintMostFrequentNum();
Console.WriteLine();

// -----------------------------------

// Practice Strings

// 1)
Class7.printReverseString1();
Class7.printReverseString2();
Console.WriteLine();

// 2)
Class8.printReverseSentence();
Console.WriteLine();

// 3)
Class9.printUniquePalindromes();
Console.WriteLine();

// 4)
Class10.ParseUrl("https://www.apple.com/iphone");
Class10.ParseUrl("ftp://www.example.com/employee");
Class10.ParseUrl("https://google.com");
Class10.ParseUrl("www.apple.com");






