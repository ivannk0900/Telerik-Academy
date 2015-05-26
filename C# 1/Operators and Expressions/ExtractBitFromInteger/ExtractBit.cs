//Problem 12. Extract Bit from Integer
// Write an expression that extracts from given integer n the value of given bit at index p.

using System;
class ExtractBit
{
    static void Main()
    {
        int n = 62241;
        int p = 11;

        int mask = 1 << p;
        int nAndMask = n & mask;
        int bit = nAndMask >> p;
        Console.WriteLine(bit);
    }
}

