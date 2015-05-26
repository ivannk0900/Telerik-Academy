// Problem 1. Sum of 3 Numbers
// Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class Sum
{
    static void Main()
    {
        double a, b, c;
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        Console.WriteLine(a+b+c);

    }
}
