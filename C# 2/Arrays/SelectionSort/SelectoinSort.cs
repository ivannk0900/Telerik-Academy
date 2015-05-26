using System;

class SelectoinSort
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
        int minValue = int.MaxValue;
        int minIndex=-1;
        for (int i = 0; i < arr.Length; i++)
        {
            minValue = int.MaxValue;
            for (int j = i; j < arr.Length; j++)
            {
                if(arr[j]<minValue)
                {
                    minValue=arr[j];
                    minIndex = j;
                }
            }
            int temp = arr[i];
            arr[i] = minValue;
            arr[minIndex] = temp;
        }
    

    Console.WriteLine(string.Join(", ",arr));
   }
}

