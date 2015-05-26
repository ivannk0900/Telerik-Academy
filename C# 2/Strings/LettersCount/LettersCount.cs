using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCount
{
    class LettersCount
    {
        static void Main()
        {
            Console.WriteLine("enter the text: ");
            string text = Console.ReadLine();
            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach(char symbol in text)
            {
                if(dict.ContainsKey(symbol))
                {
                    dict[symbol] += 1;

                   
                }

                else
                {
                    dict.Add(symbol, 1);
                }
            }


            foreach(var item in dict)
            {
                Console.WriteLine("the symbol {0} - {1} times", item.Key, item.Value);
                
            }

           

        }
    }
}
