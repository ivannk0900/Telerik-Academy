using System;
using System.IO;

namespace ReplaceSubString
{
    class Replace
    {
        
        
        static void Main()
        {
            string start = "start";
            string finish = "finish";

            StreamReader file = new StreamReader(@"..\..\..\Files\file7.txt");
            StreamWriter newFile = new StreamWriter(@"..\..\..\Files\file7-replaced.txt");
            string currentLine = file.ReadLine();
            using(file)
            {
               using(newFile)
               {
                   while(currentLine!=null)
                   {
                     string replacedLine = currentLine.Replace(start,finish);
                       newFile.WriteLine(replacedLine);
                       currentLine = file.ReadLine();
                   }
               }
            }
        }
    }
}
