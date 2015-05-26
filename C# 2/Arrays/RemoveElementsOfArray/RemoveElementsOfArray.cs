//    Write a program that reads an array of integers and removes from it a minimal
//   number of elements in such a way that the remaining array is sorted in increasing order.
//  Print the remaining sorted array.


using System;
using System.Collections.Generic;
class RemoveElementsOfArray
{
    static void Main()
    {
        Console.WriteLine("enter the length of the array");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("enter the elements of the array");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        List<int> newList = new List<int>();

        int currentEl = arr[0];
        int lastMax=int.MinValue;

        for(int i=1;i<arr.Length;i++)
        {   
           



        }

        int[] sortedArr = newList.ToArray();
        foreach(int num in sortedArr)
        {
            Console.WriteLine(num);
        }

    }
}

