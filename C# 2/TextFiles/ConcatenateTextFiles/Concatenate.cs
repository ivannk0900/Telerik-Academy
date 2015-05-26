using System;
using System.IO;
namespace ConcatenateTextFiles
{
    class Concatenate
    {
        static void Main()
        {
            StreamReader file1 = new StreamReader(@"..\..\..\Files\file2.1.txt");
            StreamReader file2 = new StreamReader(@"..\..\..\Files\file2.2.txt");

            StreamWriter file1AndFile2 = new StreamWriter(@"..\..\..\Files\ConcatenatedFile.txt");

            using(file1)
            {   
                string currentLine = file1.ReadLine();
                while(currentLine!=null)
                {
                    file1AndFile2.WriteLine(currentLine);
                    currentLine = file1.ReadLine();
                }

            }
            using (file2)
            {
                string currentLine = file2.ReadLine();
                while (currentLine != null)
                {
                    file1AndFile2.WriteLine(currentLine);
                    currentLine = file2.ReadLine();
                }

            }
            file1AndFile2.Close();
            
        }
    }
}
