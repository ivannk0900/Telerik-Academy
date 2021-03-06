﻿//   Problem 10. Point Inside a Circle & Outside of a Rectangle
//   Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//   and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;
class Point
{
    static void Main()
    {
        double x = 2;
        double y = 1.5;        
        double radius = 1.5;
        double OT = Math.Sqrt((x - 1) * (x - 1) + (1 - y) * (1 - y)); //OT-distance between the centre of the circle and the given point
        if (OT > radius) { Console.WriteLine("no"); return; }
        else
            if (y > 2) { Console.WriteLine("no"); return; }
                else Console.WriteLine("yes");
    }
}

