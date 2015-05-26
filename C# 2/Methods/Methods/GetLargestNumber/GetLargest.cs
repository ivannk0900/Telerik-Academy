//  Write a method GetMax() with two parameters that returns the larger of two integers. 
// Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().


using System;

class GetLargest
{
    static int GetMax(int a, int b)
    {
        return Math.Max(a, b);
    }
    static void Main()
    {
        Console.WriteLine("enter three integers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("the larges integer is: {0}",GetMax(GetMax(a,b),GetMax(b,c)));

    }
}

