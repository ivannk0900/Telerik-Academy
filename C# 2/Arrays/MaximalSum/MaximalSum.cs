 // Write a program that finds the sequence of maximal sum in given array.

using System;

class MaximalSum
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


        int maxSum = 0;
        int currentSum = int.MinValue;
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
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    startIndex = i;
                    endIndex = j;
                }

            }
        }
        
        Console.Write("the sequence with the max sum is: ");
        for (int i = startIndex; i < endIndex; i++)
        {

            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        Console.Write("max sum is :");
        Console.WriteLine(maxSum);
        
    }
}

