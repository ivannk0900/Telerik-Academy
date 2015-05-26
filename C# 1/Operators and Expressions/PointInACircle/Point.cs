//  Problem 7. Point in a Circle
 // Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class Point
{
    static void Main()
    {
        double x = 1.5;
        double y = 1.5;
        double radius = 2;

        bool inOrOut = (Math.Sqrt(x * x + y * y) < radius);
        Console.WriteLine(inOrOut);
    }
}

