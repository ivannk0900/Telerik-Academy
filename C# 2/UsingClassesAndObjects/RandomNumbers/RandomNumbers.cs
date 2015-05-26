using System;

class RandomNumbers
{
    static void Main()
    {
        Random randGen = new Random();
        Console.WriteLine("Random Numbers");
        for(int i=0;i<10;i++)
        {
            int a = randGen.Next(100,200);
            Console.WriteLine(a);
        }
    }

  
}

