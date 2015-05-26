using System;
using System.IO;

namespace DeleteOddLines
{
    class DeleteOdd
    {
        static void Main()
        {
            StreamReader file = new StreamReader(@"..\..\..\Files\file9.txt");
            StreamWriter helpFile = new StreamWriter(@"..\..\..\Files\file9help.txt");

            int counter = 1;
            string currentLine = file.ReadLine();

            using (file)
            {
                using (helpFile)
                {
                    while (currentLine != null) 
                    {
                        if (counter % 2 != 1)
                        {
                            currentLine.Remove(0);
                        }
                        else
                        {
                            helpFile.WriteLine(currentLine);
                        }
                        counter++;
                        currentLine = file.ReadLine();
                    }
                    

                }

            }
            
               using(StreamWriter sw = new StreamWriter(@"..\..\..\Files\file9.txt",true))
               {
                   using(StreamReader sr = new StreamReader(@"..\..\..\Files\file9help.txt"))
                   {
                       string currLine = sr.ReadLine();

                       while(currLine!=null)
                       {
                           sw.WriteLine(currLine);
                           currLine = sr.ReadLine();
                       }
                   }
               }
        }
    }
}
