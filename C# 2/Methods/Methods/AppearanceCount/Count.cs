// Write a method that counts how many times given number appears in given array.
using System;

class Count
{
    static int CountArr(int[] arr,int num)
    {
        int counter = 0;
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]==num)
            {
                counter++;
            }
        }
        return counter;
    }
    static void Main()
    {
        Console.WriteLine("enter the length of the array");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("eneter the elements of the array");
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("enter a number to count: ");
        int num=int.Parse(Console.ReadLine());
        Console.WriteLine("the number {0} appears {1} times",num,CountArr(arr,num));
    }
}

