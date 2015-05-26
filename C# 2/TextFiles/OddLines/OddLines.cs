using System;
using System.IO;
namespace OddLines
{
    class OddLines
    {
        static void Main()
        {
           
            StreamReader reader = new StreamReader(@"..\..\..\Files\file1.txt");
            int lineNum = 0;
            using (reader)
            {
                string currentLine = reader.ReadLine();
                while(currentLine!=null)
                {
                    if(lineNum%2==0)
                    {
                        Console.WriteLine(currentLine);
                    }
                    lineNum++;
                    currentLine = reader.ReadLine();
                }
            }

        }
    }
}
