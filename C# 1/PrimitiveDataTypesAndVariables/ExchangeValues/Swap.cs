//Problem 9. Exchange Variable Values

//    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//    Print the variable values before and after the exchange.


using System;

class Swap
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Initial value of a:{0}", a);
        Console.WriteLine("Initial value of b:{0}", b);
        int temp;
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("The value of a now is:{0}", a);
        Console.WriteLine("The value of b now is:{0}", b);
    }
}

