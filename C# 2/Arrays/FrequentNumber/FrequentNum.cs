using System;

class FrequentNum
{
    static void Main()
    {   
        Console.WriteLine("enter the length of the array");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        Console.WriteLine("enter the elements of the array");
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int theMostFrequent = 0;
        int theMostFrequentTimes = 0;
        int currentNum = 0;
        int currentTimes = 0;

        for (int i = 0; i < length; i++)                               // the first loop takes one number from the array
        {                                                             // and the second loop checks how many times this number
                                                                     //  occurs  in the given array
            currentNum = arr[i];
            currentTimes = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if(currentNum==arr[j])
                {
                    currentTimes++;
                }
            }
            if(currentTimes>theMostFrequentTimes)
            {
                theMostFrequentTimes = currentTimes;
                theMostFrequent = currentNum;
            }
        }

        
            Console.WriteLine("the most frequent number is {0} encountered {1} times",theMostFrequent,theMostFrequentTimes);
        
    }
}

