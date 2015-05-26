using System;

namespace ReverseString
{
    class Reverse
    {
        static void Main()
        {
            Console.WriteLine("enter the string that you want to reverse");
            string toReverse = Console.ReadLine();
           

            for(int i = toReverse.Length-1;i>=0;i--)
            {
                Console.Write(toReverse[i]);
            }
            Console.WriteLine();
        }
    }
}
