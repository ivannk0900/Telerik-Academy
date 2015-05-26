using System;
using System.Numerics;

class Factorial

{
    static BigInteger Fact(BigInteger n)
    {
        if (n == 0) return 1;
         if (n == 1) return 1;
         return n*Fact(n-1);
    }
    static void Main()
    {
        Console.WriteLine("enter the number: ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine("the factorial is {0}",Fact(n));
        
    }
}

