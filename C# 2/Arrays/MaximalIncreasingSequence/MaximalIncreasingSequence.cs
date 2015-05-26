// Problem 5. Maximal increasing sequence
// Write a program that finds the maximal increasing sequence in an array.


using System;

class MaximalIncreasingSequence
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

        int currentNumber = arr[0];
        int sequenceLength=0;
        int bestLength = 0;
        int bestNumber = 0;


        for(int i=1;i<length;i++)
        {   
            
            if(currentNumber==arr[i]-1)
            {
                currentNumber = arr[i];
                sequenceLength++;
            }
            else
            {
                currentNumber = arr[i];
                sequenceLength = 0;
            }

            if(sequenceLength>bestLength)
            {
                bestLength = sequenceLength;
                bestNumber = currentNumber;
            }
        }

        for(int i=0;i<=bestLength;i++)
        {
            Console.Write(bestNumber-bestLength+i+" ");
        }
    }
}


