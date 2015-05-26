using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCount
{
    class WordsCount
    {
        static void Main()
        {
            Console.WriteLine("enter the text: ");
            string text = Console.ReadLine();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            string[] words = text.Split(new string[] { " ", ", " },StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0 ; i < words.Length; i++)
            {
                if(dict.ContainsKey(words[i]))
                {
                    dict[words[i]] += 1;
                }
                else
                {
                    dict.Add(words[i], 1);
                }
            }

            foreach(var item in dict)
            {
                Console.WriteLine("the word {0} - {1} times", item.Key, item.Value);
            }
        }
    }
}
