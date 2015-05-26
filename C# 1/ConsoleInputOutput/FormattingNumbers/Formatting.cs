// Problem 5. Formatting Numbers

//    Write a program that reads 3 numbers:
//        integer a (0 <= a <= 500)
//        floating-point b
//       floating-point c
//    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//      The number a should be printed in hexadecimal, left aligned
//    Then the number a should be printed in binary form, padded with zeroes
//     The number b should be printed with 2 digits after the decimal point, right aligned
 //     The number c should be printed with 3 digits after the decimal point, left aligned.


using System;

class Formatting
{
    static void Main()
    {
        Console.WriteLine("enter integer a from 0 to 500");
        int a = int.Parse(Console.ReadLine());
        if (a <= 0 || a >= 500) { Console.WriteLine("wrong input"); return; }
        Console.WriteLine("enter 2 numbers with floating point");
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        int binary = int.Parse(Convert.ToString(a, 2));

        Console.WriteLine("{0,-10:X} | {1:0000000000} | {2,10:F2} | {3,-10:F3}",a,binary,b,c);
            


    }
}

