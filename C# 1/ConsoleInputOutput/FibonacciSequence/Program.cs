// Problem 10. Fibonacci Numbers
// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter an integer number");
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        for(int i=0;i<n;i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
            Console.Write((a)+", ");
        }
    }
}

