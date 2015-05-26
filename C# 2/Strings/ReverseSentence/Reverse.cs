using System;
using System.Text;

namespace ReverseSentence
{
    class Reverse
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            char endSign = text[text.Length - 1];
            StringBuilder result = new StringBuilder();
            StringBuilder tempWord = new StringBuilder();
            for(int i = text.Length-2;i>=0;i--)
            {
                
                if (text[i]!=' ')
                {
                    tempWord.Append(text[i]);
                }

                if(text[i]==' '||i==0)
                {
                    
                    result.Append(Reverse(tempWord.ToString())+" ");
                    tempWord.Clear();

                }
            }
            Console.WriteLine(result+endSign.ToString());
        }
    }
}
