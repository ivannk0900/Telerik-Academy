//  Problem 4. Maximal sequence
//  Write a program that finds the maximal sequence of equal elements in an array.

using System;

class MaximalSequence
{
    static void Main()
    {
        Console.WriteLine("enter the length of the array");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int bestLength = 0;
        int bestElement = 0;
        int currentLength = 0;
        int currentElement = arr[0];

        for (int i = 0; i < length; i++)
        {
            if(currentElement==arr[i])
            {
                currentLength++;
            }
            else
            {
                currentElement = arr[i];
                currentLength = 1;
            }

            if(currentLength>bestLength)
            {
                bestLength = currentLength;
                bestElement = currentElement;
            }
        }
        Console.WriteLine();
        Console.WriteLine("maximal sequence");
            for(int i=0;i<bestLength;i++)
            {
                Console.Write(bestElement + " ");
            }



    }
}

