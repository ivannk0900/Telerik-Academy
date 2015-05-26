using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("enter decimal number");
        int decimalNum = int.Parse(Console.ReadLine());
        string binary = null;
        while(decimalNum>0)
        {
            binary += decimalNum % 2;
            decimalNum=decimalNum / 2;
            
        }
        for (int i = binary.Length - 1; i >= 0;i-- )
        {
            Console.Write("{0}", binary[i]);
        }
        Console.WriteLine();
    }
}

