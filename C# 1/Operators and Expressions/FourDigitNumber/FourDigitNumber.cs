//         Problem 6. Four-Digit Number
//        Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//         Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//        Prints on the console the number in reversed order: dcba (in our example 1102).
//        Puts the last digit in the first position: dabc (in our example 1201).
//         Exchanges the second and the third digits: acbd (in our example 2101).
//         The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigitNumber
{
    static void Main()
    {
        int number;
        Console.WriteLine("Enter a four-digit number");
        number = int.Parse(Console.ReadLine());
        if (number < 1000 || number > 9999)
        {
            Console.WriteLine("Wrong input");
            return;
        }
        int first, second, third, fourth;
        first = number / 1000;
        second = number % 1000 / 100;
        third = number % 1000 % 100 / 10;
        fourth = number % 1000 % 100 % 10;

        Console.WriteLine("The sum of the digits is:{0}",first+second+third+fourth);
        Console.WriteLine("reversed order: {0}{1}{2}{3}",fourth,third,second,first);

        int lastDigit,first3Digits;
        lastDigit = number % 1000 % 100 % 10;
        first3Digits = number / 10;
        Console.WriteLine("last digit in the first position:{0}{1}",lastDigit,first3Digits);

        Console.WriteLine("Exchanges the second and the third digits:{0}{1}{2}{3}",first,third,second,fourth);
       
    }
        
}

