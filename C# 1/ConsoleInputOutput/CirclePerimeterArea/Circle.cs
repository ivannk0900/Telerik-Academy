//  Problem 3. Circle Perimeter and Area
//  Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;
using System.Numerics;
class Circle
{
    static void Main()
    {
        Console.Write("Enter a radius ");
        decimal r = decimal.Parse(Console.ReadLine());
        decimal area = r * r * 3.14159265358979323846m;
        decimal perimeter = 2 * r * 3.14159265358979323846m;
        Console.WriteLine("the area of the circle is: " + Math.Round(area, 2));
        Console.WriteLine("the perimeter of the circle is: " + Math.Round(perimeter, 2));


    }
}

