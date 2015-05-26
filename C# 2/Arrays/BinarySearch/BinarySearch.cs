using System;


class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("enter the length of the array");
        int length = int.Parse(Console.ReadLine());

        var arr = new int[length];
        Console.WriteLine("enter the elements of the array");
        for (int i = 0; i < length; i++)
        {
            arr[i]=int.Parse(Console.ReadLine());
        }
        
        Array.Sort(arr);
        Console.WriteLine("sorted array :");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        int start = 0;
        int end = arr.Length;
        int middleIndex = (start + end) / 2;

        Console.WriteLine("enter the number which index you search");
        int num = int.Parse(Console.ReadLine());


        Console.WriteLine(bs(arr, num, 0, arr.Length)); 
    }

    private static int bs(int[] nums, int value, int start, int end)
    {
        if (end < start)
        {
            return -1;
        }
        else
        {
            int middleIndex = (start + end) / 2;
            if (nums[middleIndex] > value)
            {
                return bs(nums, value, start, middleIndex - 1);
            }
            else if (nums[middleIndex] < value)
            {
                return bs(nums, value, middleIndex + 1, end);
            }
            else
            {
                return middleIndex;
            }
        }
    }
}

