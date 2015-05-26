using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.WriteLine("enter decimal number");
        int decimalNum = int.Parse(Console.ReadLine());
        string hexadecimal="";
        

        while(decimalNum>0)
        {
            int digit = decimalNum%16;

            if (digit % 16 >= 0 && digit % 16 <= 9)
            {
                hexadecimal = (char)('0' + digit) + hexadecimal;
            }
            else if (digit >= 10 && digit <= 15) 
            {
                hexadecimal = (char)(digit - 10 + 'A')+hexadecimal;
            }

            decimalNum/=16;
        }

        Console.WriteLine(hexadecimal);
    }
}
