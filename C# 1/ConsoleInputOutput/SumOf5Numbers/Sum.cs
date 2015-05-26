//  Problem 7. Sum of 5 Numbers
//  Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.


using System;

class Sum
{
    static void Main()
    {
        Console.WriteLine("enter 5 numbers");
        string numbers = Console.ReadLine();
        double sum = 0;
        string temp1 = null;

        for (int i = 0; i < numbers.Length; i++)
        {

            if (numbers[i] == ' ')
            {
                sum = double.Parse(temp1) + sum;
                temp1 = null;
            }
            temp1 = temp1 + numbers[i];

        }
        Console.WriteLine("the sum is: {0}", sum + double.Parse(temp1));

    }
}

