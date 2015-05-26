using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        public static String Reorder(string word)
        {   
            StringBuilder newWord = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i-- )
            {
                newWord.Append(word[i]);
            }
            return newWord.ToString();
        }
        static void Main()
        {
            Console.WriteLine("enter the text: ");
            string text = Console.ReadLine();

            string[] words = text.Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                if(words[i]==Reorder(words[i]))
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
