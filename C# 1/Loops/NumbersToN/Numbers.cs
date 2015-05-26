//Problem 1. Numbers from 1 to N

//    Write a program that enters from the console a positive integer n and prints all the numbers
//from 1 to n, on a single line, separated by a space.


using System;

class Numbers
{
    static void Main()
    {
        Console.WriteLine("enter positive integer");
        int n = int.Parse(Console.ReadLine());
        if (n < 0) { Console.WriteLine("error"); return; }
        for(int i=0;i<=n;i++)
        {
            Console.Write(i+" ");
        }
    }
}

