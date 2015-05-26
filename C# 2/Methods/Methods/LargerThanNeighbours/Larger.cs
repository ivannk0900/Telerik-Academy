// Write a method that checks if the element at given position in
// given array of integers is larger than its two neighbours (when such exist). 

using System;

class Larger
{
    static void LargerElement(int[] arr,int position)
    {
        if(position==0||position==arr.Length-1)
        {
            Console.WriteLine("the element is the first or the last");
            return;
        }
        
        if(arr[position-1]<arr[position]&&arr[position+1]<arr[position])
        {
            Console.WriteLine("the element on postition {0} is larger than its neighbours",position);
        }
        else
        {
            Console.WriteLine("the element on postition {0} is NOT larger than its neighbours",position);
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
        Console.WriteLine("enter the position of the element that you want to check");
        int position=int.Parse(Console.ReadLine());
        LargerElement(arr, position);
    }
}

