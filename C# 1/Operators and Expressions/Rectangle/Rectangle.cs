 // Problem 4. Rectangles
//  Write an expression that calculates rectangle’s perimeter and area by given width and height.


using System;

class Rectangle
{
    static void Main()
    {
        double width = 2.5;
        double height = 3;
        double perimeter = 2 * (width + height);
        double area = width * height;
        Console.WriteLine(perimeter);
        Console.WriteLine(area);
    }
}

