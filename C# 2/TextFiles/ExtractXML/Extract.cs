using System;
using System.IO;

namespace ExtractXML
{
    class Extract
    {
        static void Main()
        {
            StreamReader file = new StreamReader(@"..\..\..\Files\file10.txt");
            string currentLine = file.ReadLine();
            string word = "";

            using(file)
            {
               while(currentLine!=null)
               {
                   for(int i=0;i<currentLine.Length;i++)
                   {
                       if(currentLine[i]=='<')
                       {
                           while(currentLine[i]!='>')
                           {   
                               i++;
                               continue;
                               
                           }
                       }
                       else
                       {
                           word += currentLine[i];
                           if(currentLine[i+1]=='<')
                           {
                               Console.WriteLine(word+ " ");
                               word = "";
                           }
                       }
                   }
                   currentLine = file.ReadLine();
               }
            }
        }
    }
}
