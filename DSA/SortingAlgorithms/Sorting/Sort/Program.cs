using System;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<int>() { 3, 5, 1 };

            //var sorter = new SelectionSorter<int>();
            //sorter.Sort(myList);

            //var quickSorter = new Quicksorter<int>();
            //quickSorter.Sort(myList);

            var mergeSorter = new MergeSorter<int>();
            mergeSorter.Sort(myList);


            foreach (var el in myList)
            {
                Console.WriteLine(el);
            }
        }
    }
}