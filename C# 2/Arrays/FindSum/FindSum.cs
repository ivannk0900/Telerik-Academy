// Write a program that finds in given array of integers a sequence of given sum S (if present)
using System;

class FindSum
{
    static void Main()
    {
        Console.WriteLine("enter the length of the array");
        int length = int.Parse(Console.ReadLine());
        var arr = new int[length];

        Console.WriteLine("enter the elements of the array");
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("enter the sum that you want to find");
        int sum = int.Parse(Console.ReadLine());
        int currentSum = 0;
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i <= arr.Length - 1; i++)
        {
            
            for (int j = arr.Length; j >= i + 1; j--)
            {
                currentSum = 0;
                for (int p = i; p < j; p++)
                {
                    currentSum += arr[p];
                }
                if (currentSum == sum)
                {
                    startIndex = i;
                    endIndex = j;
                }

            }
        }
       if(startIndex==0&&endIndex==0)
       {
           Console.WriteLine("no matches found");
       }
        for (int i = startIndex; i < endIndex; i++)
        {
            
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();


    }
}

