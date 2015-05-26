using System;
using System.Text;

namespace Sub_StringInText
{
    class SubString
    {
        static void Main()
        {
            Console.WriteLine("enter the text");
            string text = Console.ReadLine();
            Console.WriteLine("enter the searcher sub-string");
            string subStr = Console.ReadLine();
            int lengthOfSubStr = subStr.Length;
            int counter = 0;

            int index = 0;
            while (true)
            {
                int foundPosition = text.IndexOf(subStr, index);

                if(foundPosition<0)
                {
                    break;
                }
                counter++;
                index = foundPosition + 1;
            }
            Console.WriteLine("the searched substring  \"{0}\" is found {1} times ",subStr, counter);


        }

      
    }
}
