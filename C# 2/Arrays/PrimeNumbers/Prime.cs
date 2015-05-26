using System;

class Prime
{
    static void Main()
    {
        bool[] primeNums = new bool[10000000];

        
        for (int i = 2; i < Math.Sqrt(primeNums.Length); i++)
        {
            
            if (primeNums[i] == false)
            {
                for (int j = i * i; j < primeNums.Length; j += i)
                {
                    primeNums[j] = true;
                }
            }
        }
        
        for (int i = 2; i < primeNums.Length; i++)
        {
            if (!primeNums[i]) Console.Write(i + " ");
        }
    }

   
}
