// Problem 8. Prime Number Check
//Write an expression that checks if given positive integer number n (n <= 100) is prime
//(i.e. it is divisible without remainder only to itself and 1).
// Note: You should check if the number is positive

using System;


class PrimeNumber
{
    static void Main()
    {
        int n = 4;
        bool isPrime = true;
        if (n > 100) {  Console.WriteLine("wrong input"); return; }
         
   

        if(n>0)
        {
            for(int i=2;i<=n-1;i++)
            {
                if (n % i == 0) 
                {   
                    isPrime = false;
                    Console.WriteLine(isPrime);
                    return;
                }
            }
        }
        else
        {
            for(int i=-2;i>=n+1;i--)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    Console.WriteLine(isPrime);
                    return;
                }
            }
        }

        Console.WriteLine(isPrime);
    }
}

