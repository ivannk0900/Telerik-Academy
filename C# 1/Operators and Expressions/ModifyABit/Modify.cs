//Problem 14. Modify a Bit at Given Position
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the
// value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class Modify
{
     static void Main()
     {
         int n = 5343;
         int v = 0;
         int p = 7;

         if(v==0)
         {
             int mask = ~(1 << p);
             int result = n & mask;
             Console.WriteLine(result);
         }

         else 
         {
             int mask2=1<<p;
             int result2 = n|mask2;
             Console.WriteLine(result2);
         }
    }
}

