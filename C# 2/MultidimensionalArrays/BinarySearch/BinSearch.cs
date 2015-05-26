// Write a program, that reads from the console an array of N integers and an integer K, sorts the array and
// using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
using System;

class BinSearch
{
  

    static void Main()
    {
        Console.WriteLine("enter the length of the array");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("enter the elements of the array");
        for (int i = 0; i < arr.Length;i++ )
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

            Console.WriteLine("enter number K");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(arr);

        while(Array.BinarySearch(arr,k)<0)
        {
            k--;
        }
        Console.WriteLine("Largest number in the array which is less or equal to K is " + k);


    }
}

