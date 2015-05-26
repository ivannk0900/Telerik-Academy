//Problem 9. Play with Int, Double and String

//    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//        If the variable is int or double, the program increases it by one.
//        If the variable is a string, the program appends * at the end.
//    Print the result at the console. Use switch statement.


using System;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine("please enter a choice:");
        Console.WriteLine("1-->Int");
        Console.WriteLine("2-->Double");
        Console.WriteLine("3-->String");

        int choice = 0;
        choice = int.Parse(Console.ReadLine());
        if (choice < 1 || choice > 3)
        {
            Console.WriteLine("incorrect value");
            return;
        }

        switch (choice)
        {
            case 1:
                {
                    int input;
                    Console.WriteLine("enter an integer number");
                    input = int.Parse(Console.ReadLine());
                    input = input+1;
                    Console.WriteLine(input);
                    break;
                }
            case 2:
                {
                    Console.WriteLine("enter a real number");
                    double input1 = double.Parse(Console.ReadLine());
                    input1 = input1+1;
                    Console.WriteLine(input1);
                    break;
                }
            case 3:
                {
                    Console.WriteLine("enter a string");
                    string input3 = Console.ReadLine();
                    input3 = input3 + '*';
                    Console.WriteLine(input3);
                    break;
                }
        }




    }
}

