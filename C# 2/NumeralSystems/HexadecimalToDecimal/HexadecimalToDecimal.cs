using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        string hexadecimal = null;
        Console.WriteLine("enter hexadecimal number");
        hexadecimal = Console.ReadLine();
        int decimalNum = 0;
        int digit = 0;
        for(int i=0;i<hexadecimal.Length;i++)
        {
            if(hexadecimal[i]>='0'&&hexadecimal[i]<='9')
            {
                digit = hexadecimal[i] - '0';
            }
            else if(hexadecimal[i]>='A'&&hexadecimal[i]<='F')
            {
                digit = hexadecimal[i] - 'A' + 10;
            }
            decimalNum += digit * (int)Math.Pow(16, hexadecimal.Length - 1 - i);
        }

        Console.WriteLine(decimalNum);
    }
}

