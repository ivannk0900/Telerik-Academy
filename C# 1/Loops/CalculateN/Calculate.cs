// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).

using System;

class Calculate
{
    static void Main()
    {   
        start:
        Console.WriteLine("enter k<100");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("enter n<100");
        int n = int.Parse(Console.ReadLine());
        if (k > 100 || k < 1 || n < 1 || n > 100 || k > n)
        {
            Console.WriteLine("wrong input 1 < k < n < 100");
            goto start;
        }

        int nFactorial = 1;
        for(int i=1;i<=n;i++)
        {
            nFactorial *= i;
        }
       

        int kFactorial = 1;
        for (int i = 1; i <= k; i++)
        {
            kFactorial *= i;
        }
       

        Console.WriteLine("n!/k! = {0}",(double)nFactorial/kFactorial);
    }
}
