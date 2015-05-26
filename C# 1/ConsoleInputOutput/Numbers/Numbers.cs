// Problem 8. Numbers from 1 to n
// Write a program that reads an integer number n from the console
// and prints all the numbers in the interval [1..n], each on a single line.


using System;

class Numbers
{
    static void Main()
    {
        Console.WriteLine("enter a positive number: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0) { Console.WriteLine("wrong input"); return; }
        for (int i = 1; i <= n; i++) Console.WriteLine(i);
    }
}
