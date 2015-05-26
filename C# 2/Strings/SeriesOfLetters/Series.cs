using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class Series
    {
        static void Main()
        {
            Console.WriteLine("enter the sequence of letters: ");
            string lettersString = Console.ReadLine();
            

            List<char> charsStr = new List<char>();
            
            foreach (var symbol in lettersString)
            {
                charsStr.Add(symbol);            
            }

            HashSet<char> letters = new HashSet<char>();

            for (int i = 0; i < charsStr.Count; i++)
            {
                letters.Add(charsStr[i]);
            }

            foreach (var item in letters)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
