//Problem 11. Random Numbers in Given Range
//    Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].


using System;

class RandomNumber
{
    static void Main()
    {
        Console.WriteLine("enter minimal number");
        int min = int.Parse(Console.ReadLine());
        Console.WriteLine("enter maximal number");
        int max = int.Parse(Console.ReadLine());
        Console.WriteLine("enter amount of random numbers");
        int n = int.Parse(Console.ReadLine());
        if (min >= max) Console.WriteLine("incorrect input");

        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.Write(random.Next(min, max) + " ");
        }
    }
}

