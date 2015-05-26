using System;

class TheBiggestOf3
{
    static void Main()
    {
        Console.WriteLine("enter three real numbers");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double biggest = 0;
        if (a > b && a > c) biggest = a;
        if (b > a && b > c) biggest = b;
        if (c > a && c > b) biggest = c;
        Console.WriteLine("the biggest number is {0}", biggest);
    }

}
