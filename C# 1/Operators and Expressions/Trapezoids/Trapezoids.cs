 //  Problem 9. Trapezoids
 //  Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class Trapezoids
{
    static void Main()
    {
        double a = 0.222;
        double b = 0.333;
        double h = 0.555;
        double area = ((a + b) * h) / 2;

        Console.WriteLine(area);
    }
}
