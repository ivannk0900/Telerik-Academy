using System;
using System.Collections.Generic;

class Program
{ 
    static void Main()
    {   
        Console.WriteLine("enter the length of the array");
        int length=int.Parse(Console.ReadLine());

        int[] arr=new int[length];
        for (int i = 0; i <arr.Length; i++)
			{
			 arr[i]=int.Parse(Console.ReadLine());
			}


    }
     private static int quick(int[] arr)
    {
        List<int> less = new List<int>();
        List<int> greater = new List<int>();
        int master;

         if(arr[arr.Length]<=1)
         {
             return arr[arr.Length];
         }
         for(int i=1;i<arr.Length;i++)
         {
             master = arr[i-1];
             if(master>arr[i])
             {
                 less.Add(arr[i]);
             }
             else
             {
                 greater.Add(arr[i]);
             }
         }



    }

}