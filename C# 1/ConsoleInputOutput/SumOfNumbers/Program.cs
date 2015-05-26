// Problem 9. Sum of n Numbers
// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter integer number n");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("enter n in numbers numbers");
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum = sum + double.Parse(Console.ReadLine());

        }
        Console.WriteLine("the sum is: "+sum);
    }
}

