using System;
using System.Text;

namespace UnicodeCharacters
{
    class UnicodeChars
    {

        static string ToUnicode(string text)
        {
            StringBuilder result = new StringBuilder();

            foreach(char symbol in text)
            {
                result.Append(String.Format("\\u{0:X4}",(int)symbol));
            }
            return result.ToString();
        }
        static void Main()
        {

            Console.WriteLine("enter text for converting to unicode");
            string text = Console.ReadLine();
             string result = ToUnicode(text);
             Console.WriteLine(result);
            
        }
    }
}
