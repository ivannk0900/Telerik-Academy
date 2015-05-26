// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;
using System.Text;

namespace ReplaceTags
{
    class Replace
    {
        static void Main()
        {
            Console.WriteLine("enter the text");
            String text = Console.ReadLine();



            string first = "<a href=\"";
            string second = "\">";
            string third = "</a>";

            string toFirst = "[URL=";
            string toSecond = "]";
            string toThird = "[/URL]";


            StringBuilder result = new StringBuilder();
            result.Append(text);

            int index1 = 0;
            int index2 = 0;
            int index3 = 0;

            for (int i = 0; i < result.Length; i++)
            {
                int indexFirst = result.ToString().IndexOf(first, index1);
                if (indexFirst >= 0)
                {
                    result.Replace(first, toFirst);
                }
                index1++;
            }

            for (int i = 0; i < result.Length; i++)
            {
                int indexSecond = result.ToString().IndexOf(second, index2);
                if (indexSecond >= 0)
                {
                    result.Replace(second, toSecond);
                }
                index2++;
            }

            for (int i = 0; i < result.Length; i++)
            {
                int indexThird = result.ToString().IndexOf(third, index3);
                if (indexThird >= 0)
                {
                    result.Replace(third, toThird);
                }
                index3++;
            }


            Console.WriteLine();
            Console.WriteLine(result);

        }
    }
}

