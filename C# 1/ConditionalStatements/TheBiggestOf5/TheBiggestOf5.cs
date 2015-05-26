using System;

//Write a program that finds the biggest of five numbers by using only five if statements.

class TheBiggestOf5
{
    static void Main()
    {
        Console.WriteLine("enter five real numbers");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        double biggest = 0;
        if (a > b && a > c && a > d && a > e) biggest = a;
        if (b > a && b > c && b > d && b > e) biggest = b;
        if (c > a && c > b && c > d && c > e) biggest = c;
        if (d > a && d > b && d > c && d > e) biggest = d;
        if (e > a && e > b && e > c && e > d) biggest = e;

        Console.WriteLine("the biggest number is {0}",biggest);

    }
}

