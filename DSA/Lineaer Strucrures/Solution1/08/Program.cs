//*The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
//Write a program to find the majorant of given array(if exists).
using System;
using System.Collections.Generic;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {

            var myList = new List<int>() { 2, 2, 3, 3, 2, 3, 4, 3, 3};
            var occurances = new Dictionary<int, int>();

            for (int i = 0; i < myList.Count; i++)
            {
                if (occurances.ContainsKey(myList[i])) continue;
                int timesOccur = 0;

                for (int j = 0; j < myList.Count; j++)
                {
                    if (myList[i] == myList[j]) timesOccur++;
                }

                occurances.Add(myList[i], timesOccur);
            }


            foreach(var el in occurances)
            {
                if(el.Value >= myList.Count/2 + 1)
                {
                    Console.WriteLine(el.Key);
                }
            }
        }
    }
}
