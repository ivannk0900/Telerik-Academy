using System;
using System.Globalization;

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("enter a year:");
        int year = int.Parse(Console.ReadLine());
        Console.Write("is {0} leap year: ",year);
        Console.Write(DateTime.IsLeapYear(year));
        Console.WriteLine();
    }
}

