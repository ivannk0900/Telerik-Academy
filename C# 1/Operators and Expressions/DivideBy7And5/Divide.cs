//  Problem 3. Divide by 7 and 5
//  Write a Boolean expression that checks for given integer if it can be divided (without remainder) 
//  by 7 and 5 at the same time.

using System;

class Divide
{
    static void Main()
    {
        int var1 = 35;
        bool divide=(var1%5==0&&var1%7==0);
        Console.WriteLine("The variable is 35 {0}",divide);

        int var2 = 7;
        bool divide1 = (var2 % 5 == 0 && var2 % 7 == 0);
        Console.WriteLine("The variable is 7 {0}",divide1);


    }
}

