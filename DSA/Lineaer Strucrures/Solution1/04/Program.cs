//Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.
using System;
using System.Collections.Generic;

namespace _04
{
    class Program
    {
        static void Main()
        {
            var myList = new List<int> { 1, 23, 5, 5, 5, 5, 3, 3, 1, 1, 1, 1, 1, 2, 4, 1 };

            var foo = LongestSubsequence(myList);
            foreach (var el in foo)
            {
                Console.WriteLine(el);
            }
        }

        public static List<int> LongestSubsequence(List<int> list)
        {
            var resultList = new List<int>();
            int startIndex;
            int number = list[0];
            int maxOccurances = 1;

            for (int i = 0; i < list.Count; i++)
            {
                int occurances = 1;


                for (int j = i; j < list.Count - 1; j++)
                {
                    startIndex = i;
                    if (list[j] == list[j + 1])
                    {
                        occurances++;
                        if (occurances > maxOccurances)
                        {
                            maxOccurances = occurances;
                            number = list[j];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < maxOccurances; i++)
            {
                resultList.Add(number);
            }

            return resultList;
        }
    }
}
