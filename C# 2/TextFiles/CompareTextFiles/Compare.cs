using System;
using System.IO;

namespace CompareTextFiles
{
    class Compare
    {
        static void Main()
        {
            StreamReader reader1 = new StreamReader(@"..\..\..\Files\file4.1.txt");
            StreamReader reader2 = new StreamReader(@"..\..\..\Files\file4.2.txt");
            int equalLines = 0;
            int differentLines = 0;
            using (reader1)
            {
                using (reader2)
                {
                    string reader1Line = reader1.ReadLine();
                    string reader2Line = reader2.ReadLine();

                    while (reader1Line != null || reader2Line != null)
                    {
                        if (reader1Line == reader2Line)
                        {
                            equalLines++;
                        }
                        else
                        {
                            differentLines++;
                        }
                        reader1Line = reader1.ReadLine();
                        reader2Line = reader2.ReadLine();
                    }
                }
            }
            Console.WriteLine("equal lines - {0}", equalLines);
            Console.WriteLine("different lines - {0}", differentLines);
        }
    }
}
