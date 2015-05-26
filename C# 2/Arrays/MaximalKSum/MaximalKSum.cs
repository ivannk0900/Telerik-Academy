// Problem 6. Maximal K sum
//  Write a program that reads two integer numbers N and K and an array of N elements from the console.
//  Find in the array those K elements that have maximal sum.


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter number n which will be the length of the array");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("enter number k");
        int k = int.Parse(Console.ReadLine());

        int[] nAarray = new int[n];
        Console.WriteLine("enter the elements of the array");
        for (int i = 0; i < n; i++)
        {
            nAarray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(nAarray);
        int maxSum = 0;
        for (int i = nAarray.Length - 1; i >= nAarray.Length - k; i--)
        {
            maxSum += nAarray[i];
        }

        Console.WriteLine("the maximal k sum is: {0}", maxSum);
    }
}

