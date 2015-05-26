// Problem 13. Check a Bit at Given Position
// Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
// in given integer number n, has value of 1.

using System;
class Check
{
    static void Main()
    {
        int n = 62241;
        int p = 11;

        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        bool val1 = (bit == 1);
        Console.WriteLine(val1);
    }
}

