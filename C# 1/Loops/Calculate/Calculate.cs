// Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
// n!/x^n

using System;

class Calculate
{
    
    static void Main()
    {   Console.WriteLine("enter number n");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("enter number x");
        int x=int.Parse(Console.ReadLine());
        double sum = 1;

        for(int i=1;i<=n;i++)
        {
            int iFactorial = 1;
            for (int j = 1; j <= i;j++ )
            {
                iFactorial *= j;
            }
            

            sum += (double)(iFactorial /Math.Pow(x, i));

        }

         Console.WriteLine("sum {0:F5}",sum);
    }
}

