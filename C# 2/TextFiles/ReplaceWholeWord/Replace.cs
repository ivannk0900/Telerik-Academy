using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ReplaceWholeWord
{
    class Replace
    {
        static void Main()
        {
           

            StreamReader file = new StreamReader(@"..\..\..\Files\file8.txt");
            StreamWriter newFile = new StreamWriter(@"..\..\..\Files\file8-replaced.txt");
            string currentLine = file.ReadLine();
            using (file)
            {
                using (newFile)
                {
                    while (currentLine != null)
                    {
                        currentLine = currentLine.ToLower();
                        currentLine = Regex.Replace(currentLine, @"\bstart\b", "finish");
                      

                        newFile.WriteLine(currentLine);
                        currentLine = file.ReadLine();
                    }
                }
            }
        }
    }
}
