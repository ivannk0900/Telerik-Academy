﻿//Write a program that reads a number and prints it as a
//decimal number, hexadecimal number, percentage and in scientific notation.
//Format the output aligned right in 15 symbols.

using System;

namespace FormatNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter a number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}",num);
            Console.WriteLine("{0,15:X}",num);
            Console.WriteLine("{0,15:P}",num/100.0);
            Console.WriteLine("{0,15:E}",num);

        }
    }
}
