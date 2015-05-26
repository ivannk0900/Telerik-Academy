//Problem 3. Compare char arrays

//    Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareChar
{
    static void Main()
    {   

        Console.WriteLine("enter the length of the two char arrays");
        int length =int.Parse(Console.ReadLine());
        char[] arr1=new char[length];
        char[] arr2 = new char[length];
        Console.WriteLine("enter first array");
        for (int i = 0; i < length; i++)
        {
            arr1[i] = char.Parse(Console.ReadLine());
        }
        Console.WriteLine("enter second array");
        for (int i = 0; i < length; i++)
        {
            arr2[i] = char.Parse(Console.ReadLine());
        }

        bool equal = true;

        for (int i = 0; i < length; i++)
        {
            if(arr1[i]!=arr2[i])
            {
                equal = false;
            }
            break;
        }
        if (equal == true)
        {
            Console.WriteLine("the char arrays are equal");
        }
        else
        {
            Console.WriteLine("the char arrays aren't equal");
        }
    }
}

