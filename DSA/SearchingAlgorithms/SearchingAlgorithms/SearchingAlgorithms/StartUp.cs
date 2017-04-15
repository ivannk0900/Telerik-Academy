using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    class StartUp
    {
        static void Main()
        {
            var myList = new List<int>() { 3, 7, 12, 7, 1, 0, 6, -1 };
            //var sorter = new SelectionSorter<int>();
            //sorter.Sort(myList);

            var sorter = new MergeSorter<int>();
            sorter.Sort(myList);

            foreach(var el in myList)
            {
                Console.WriteLine(el);
            }
        }
    }
}
