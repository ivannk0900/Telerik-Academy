using System;


class BinaryToDecimal
{
    static void Main()
    {

        string binary = Console.ReadLine();
        long decimalNumber = 0;
        int power = 1;

        for (int i = binary.Length - 1; i >= 0; i--)
        {
            int num = binary[i] - 48;
            decimalNumber += num * power;
            power *= 2;
        }
        Console.WriteLine(decimalNumber);


    }
}
