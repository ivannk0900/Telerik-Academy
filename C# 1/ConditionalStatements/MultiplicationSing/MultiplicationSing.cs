//Problem 4. Multiplication Sign
//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.

using System;

class MultiplicationSing
{
    static void Main()
    {
        Console.WriteLine("enter three real numbers");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if(a==0||b==0||c==0)
        {
            Console.WriteLine("the sign is 0");
        }

        int signa = Math.Sign(a);
        int signb = Math.Sign(b);
        int signc = Math.Sign(c);

        if (signa * signb * signc == 1) Console.WriteLine("the sign is +");
        if (signa * signb * signc == -1) Console.WriteLine("the sign is -");

    }
}

