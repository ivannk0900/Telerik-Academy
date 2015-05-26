using System;
//Write a program that enters 3 real numbers and prints them sorted in descending order.
class Sort
{
    static void Main()
    {
        Console.WriteLine("enter three real numbers");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        if (a == b && a == c && b == c) Console.WriteLine("{0} {1} {2}", a, b, c);

        if (a > b && a > c)
        {
            if (b > c) Console.WriteLine("sorted numbers: {0} {1} {2}", a, b, c);
            else Console.WriteLine("sorted numbers: {0} {1} {2}", a, c, b);
        }
        if (b > a && b > c)
        {
            if (a > c) Console.WriteLine("sorted numbers: {0} {1} {2}", b, a, c);
            else Console.WriteLine("sorted numbers: {0} {1} {2}", b, c, a);
        }
        if (c > a && c > b)
        {
            if (a > b) Console.WriteLine("sorted numbers: {0} {1} {2}", c, a, b);
            else Console.WriteLine("sorted numbers: {0} {1} {2}", c, b, a);
        }

    }
}

