//  Problem 12. Null Values Arithmetic
//  Create a program that assigns null values to an integer and to a double variable.
//  Try to print these variables at the console.
//  Try to add some number or the null literal to these variables and print the result.


using System;

class NullValues
{
    static void Main()
    {
        int? var1 = null + 2;
        double? var2 = null;

        Console.WriteLine(var1);
        Console.WriteLine(var2);

    }
}
