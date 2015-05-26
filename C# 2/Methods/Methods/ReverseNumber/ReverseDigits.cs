// Write a method that reverses the digits of given decimal number.
using System;

class ReverseDigits
{
    static void reverse(decimal n)
    {   
        int counter=0;
        
        
        foreach(var symbol in n.ToString())
        {
            counter++;
        }

        string stringNumber = n.ToString();
        char[] number = new char[counter];
        for(int i=0;i<counter;i++)
        {
            number[i] = stringNumber[i];
        }
        Array.Reverse(number);
        foreach(var item in number)
        {
            Console.Write(item);
        }
        Console.WriteLine();
        
    }
    static void Main()
    {
        Console.WriteLine("enter the decimal number");
        decimal num = decimal.Parse(Console.ReadLine());

        reverse(num);

        
    }
}
