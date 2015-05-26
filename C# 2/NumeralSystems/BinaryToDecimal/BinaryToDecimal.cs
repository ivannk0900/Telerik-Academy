using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("enter the number in binary");
        string binary = Console.ReadLine();
        double decimalNum = 0;
        for(int i=0;i<binary.Length;i++)
        {
            int digit = binary[i] - '0';
            int pow = binary.Length - i - 1;
            decimalNum += (double)digit * Math.Pow(2, pow);
        }
        Console.WriteLine("the number in decimal is: {0}",decimalNum);
    }
}
