//Write a program that reads a sequence of integers(List<int>) ending with an empty line and sorts them in an increasing order.

using System;
using System.Collections.Generic;

namespace _03
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
                if (s == "" || s == null)
                {
                    break;
                }

                myList.Add(int.Parse(s));
            }


            for (int i = 0; i < myList.Count; i++)
            {
                for (int j = i + 1; j < myList.Count; j++)
                {

                    if(myList[i] > myList[j])
                    {
                        var temp = myList[i];
                        myList[i] = myList[j];
                        myList[j] = temp;
                    }

                }
            }

            Console.WriteLine("Sorted:");
            foreach(var el in myList)
            {
                Console.WriteLine(el);
            }
        }
    }
}
