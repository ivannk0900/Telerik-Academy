using System;
using System.Text;

namespace ForbiddenWords
{
    class Forbidden
    {
        static void Main()
        {
            string forbiddenWords = "PHP CLR Microsoft ";

            string[] forbiddenWordsArr = forbiddenWords.Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);

           string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR";
          


            StringBuilder result = new StringBuilder();
            result.Append(text);
            int startIndex = 0;
            for (int i = 0; i < forbiddenWordsArr.Length; i++)
            {



                while (true)
                {
                    int indexFWord = text.IndexOf(forbiddenWordsArr[i], startIndex);
                    if (indexFWord < 0)
                    {
                        break;
                    }
                    if (indexFWord >= 0)
                    {


                        string oldChar = text.Substring(indexFWord, forbiddenWordsArr[i].Length);

                        result.Replace(oldChar, new string('*',oldChar.Length));

                        startIndex+=indexFWord+1;
                    }


                }
                startIndex = 0;
            }
            Console.WriteLine(result);
           

        }
    }
}
