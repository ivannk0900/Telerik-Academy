//Write a program that removes from given sequence all numbers that occur odd number of times.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main()
        {
            var myList = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
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
                if(el.Value % 2 == 1)
                {
                    myList.RemoveAll(n => n == el.Key);
                }
            }

            foreach(var el in myList)
            {
                Console.WriteLine(el);
            }
        }
    }
}
