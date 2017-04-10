//Write a program that removes from given sequence all negative numbers.
using System;
using System.Collections.Generic;

namespace _05
{
    class Program
    {
        static void Main()
        {
            var myList = new List<int> { 1, 23, -5, 5, 5, 5, 3, 3, -1, 1, 1, 1, 1, -2, 4, 1 };

            myList.RemoveAll(el => el < 0);

            foreach (var el in myList)
            {
                Console.WriteLine(el);
            }
        }
    }
}
