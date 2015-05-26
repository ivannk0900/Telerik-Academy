using System;

class CatalianNumbers
{
    static void Main()
    {   
        start:
        Console.WriteLine("enter n>0");
        int n = int.Parse(Console.ReadLine());
        if (n<0||n>100)
        {
            Console.WriteLine("wrong input 1 < k < n < 100");
            goto start;
        }

        int nFactorial = 1;
        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }
      

        int n2Factorial = 1;
        for (int i = 1; i <= 2*n; i++)
        {
            n2Factorial *= i;
        }
        

        int n_1Factorial = 1;
        for (int i = 1; i <= n+1; i++)
        {
            n_1Factorial *= i;
        }
      

        Console.WriteLine("the catalian number is: {0}",(double)n2Factorial/(n_1Factorial*nFactorial));
    }
}
