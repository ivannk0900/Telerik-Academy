using System;
using System.IO;

namespace LineNumbers
{
    class LineNum
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\..\Files\file1.txt");
            StreamWriter writer = new StreamWriter(@"..\..\..\Files\NumeratedFile.txt");
            int indexer = 1;
            using (reader)
            {
                string currentLine = reader.ReadLine();
                while(currentLine!=null)
                {
                    writer.WriteLine("{0:D2}. "+currentLine,indexer);
                    currentLine = reader.ReadLine();
                    indexer++;
                }
            }

            writer.Close();
        }
    }
}
