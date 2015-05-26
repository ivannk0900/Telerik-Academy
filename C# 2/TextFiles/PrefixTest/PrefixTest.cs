using System;
using System.IO;
using System.Text.RegularExpressions;

namespace PrefixTest
{
    class PrefixTest
    {
        static void Main()
        {
            StreamReader file = new StreamReader(@"..\..\..\Files\file11.txt");
            StreamWriter newFile = new StreamWriter(@"..\..\..\Files\file11testremoved.txt");

            using (file)
            {
                using(newFile)
                {
                    string currentLine = file.ReadLine();

                    while(currentLine!=null)
                    {
                        newFile.WriteLine(Regex.Replace(currentLine, @"\btest\w*\b", String.Empty));
                        currentLine = file.ReadLine();
                    }
                }
            }
        }
    }
}
