// Write a method that returns the index of the first
// element in array that is larger than its neighbours, or -1, if there’s no such element.

using System;

class FirstLarger
{
    static void LargerElement(int[] arr )
    {
        bool existElement = false;

        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i - 1] < arr[i] && arr[i + 1] < arr[i])
            {
                Console.WriteLine("the element on postition {0} is larger than its neighbours", i);
                existElement = true;
            }
            else if(existElement==false)
            {
                Console.WriteLine("-1");
            }
        }
    }
    static void Main()
    {
        Console.WriteLine("enter the length of the array");
        int length = int.Parse(Console.ReadLine());

        Console.WriteLine("enter the elements of the array");
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        
        LargerElement(arr);
    }
}

