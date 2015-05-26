using System;

class Calculations
{   
    static void Calculate(int[] arr)
    {
        

        int maximal = int.MinValue;
        int minimal = int.MaxValue;
        int product = 1;
        int sum = 0;
        

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > maximal)
            {
                maximal = arr[i];
            }
            if (arr[i] < minimal)
            {
                minimal = arr[i];
            }
            product *= arr[i];
            sum += arr[i];
        }
        double avarage = (double)sum / arr.Length;
            Console.WriteLine("maximal element = {0}",maximal);
            Console.WriteLine("minimal element = {0}",minimal);
            Console.WriteLine("avarage = {0}",avarage);
            Console.WriteLine("sum = {0}",sum);
            Console.WriteLine("product = {0}",product);
        

    }
    static void Main()
    {
        Console.WriteLine("enter the length of the set");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the elements");
        int[] arr = new int[length];
        for(int i=0;i<arr.Length;i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Calculate(arr);
    }
}

