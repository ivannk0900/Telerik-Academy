//Write a program that reads from the console a sequence of positive integer numbers.
//The sequence ends when empty line is entered.
//Calculate and print the sum and average of the elements of the sequence.
//Keep the sequence in List<int>.

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinearStructures
{
    class Program
    {
        static void Main()
        {
            var myList = new List<int>();

            string s = null;



            while (true)
            {
                s = Console.ReadLine();
                if(s == "" || s == null)
                {
                    break;
                }

                myList.Add(int.Parse(s));
            }

            Console.WriteLine("The sum is: {0}: ", myList.Sum());
            Console.WriteLine("The average is {0}:", myList.Average());

        }
    }
}
