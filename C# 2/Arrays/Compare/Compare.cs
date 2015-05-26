//Problem 2. Compare arrays

//    Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class Compare
{
    static void Main()
    {
        Console.WriteLine("enter the length of the two arrays");
        int length = int.Parse(Console.ReadLine());
        int[] arr1 = new int[length];
        int[] arr2 = new int[length];
        Console.WriteLine("enter the first array");
        for (int i = 0; i < length; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("enter the second array");
        for (int i = 0; i < length; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
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

        if(equal==true)
        {
            Console.WriteLine("the arrays are equal");
        }
        else
        {
            Console.WriteLine("the arrays aren't equal");
        }
    }
}
