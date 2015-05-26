using System;
// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

namespace OrderWords
{
    class Order
    {
        static void Main()
        {
            string listOfWords = "duck apple TV chair bed car bus knee truck";
            string[] wordsStr = listOfWords.Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(wordsStr);

            foreach(var item in wordsStr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
