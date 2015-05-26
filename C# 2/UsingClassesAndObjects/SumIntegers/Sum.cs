using System;


namespace SumIntegers
{
    class Sum
    {
        static void Main()
        {
            string numbers = "43 68 9 23 318";

            string[] num = numbers.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            
            int sum=0;

           for(int i=0;i<num.Length;i++)
           {
               string a = num[i];
               int b = int.Parse(a);
               sum += b;
           }

           Console.WriteLine(sum);
        }
    }
}
