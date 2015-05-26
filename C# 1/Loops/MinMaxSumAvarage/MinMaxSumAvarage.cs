//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

using System;



class MinMaxSumAvarage
{
    static void Main()
    {
        Console.WriteLine("enter n-number of values");
        int n = int.Parse(Console.ReadLine());
        int[] values = new int[n];
        Console.WriteLine("enter the values");
        for (int i = 0; i < n; i++)
        {
            values[i] = int.Parse(Console.ReadLine());
        }

        
        int max = values[0];
        int min = values[0];
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += values[i];
            if (max < values[i]) max = values[i];
            if (min > values[i]) min = values[i];
        }

        Console.WriteLine("max = {0}",max);
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("average = "+(double)sum/n);
         


    }
}
