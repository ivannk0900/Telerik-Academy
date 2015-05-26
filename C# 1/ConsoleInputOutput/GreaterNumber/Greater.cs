 //Problem 4. Number Comparer
// Write a program that gets two numbers from the console and prints the greater of them.
 // Try to implement this without if statements.


using System;

class Greater
{
    static void Main()
    {
        Console.Write("enter first number ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("enter second number ");
        double b = double.Parse(Console.ReadLine());

        bool equation = a == b;
        bool greater = a > b;

        switch (equation)
        {
            case true: { Console.WriteLine("The two numbers are equal"); break; }
            case false:
                {
                    switch (greater)
                    {
                        case true: Console.WriteLine("greater: "+a); break;
                        case false: Console.WriteLine("grater "+b); break;
                    }
                    break;
                }
        }

       

    }
}
