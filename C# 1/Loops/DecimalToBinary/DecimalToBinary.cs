using System;

class DecimalToBinary
{
    static void Main()
    {
        int decimalNum = int.Parse(Console.ReadLine());
        string binNumber = "";
        while (decimalNum != 0)
        {
            int remain = (int)decimalNum % 2;
            decimalNum /= 2;
            binNumber = remain + binNumber;
        }
        Console.WriteLine(binNumber);


    }
}

