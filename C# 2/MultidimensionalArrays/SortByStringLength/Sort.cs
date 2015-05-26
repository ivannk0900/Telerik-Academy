// You are given an array of strings. Write a method that sorts the
// array by the length of its elements (the number of characters composing them).
using System;

class Sort
{
    static void Sorting(string[] arr)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i+1; j < arr.Length; j++)
            {

                if (arr[j].Length > arr[i].Length)
                {   
                    string temp = null;
                    temp = arr[j];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("enter the length of the array");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the string elements of the array");
        string[] arr=new string[n];

        for(int i=0;i<arr.Length;i++)
        {
           arr[i] = Console.ReadLine();
        }

        Sorting(arr);
        Console.WriteLine();
        Console.WriteLine("the sorted array is: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("{0}",arr[i]);
        }
    }
}
