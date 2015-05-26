using System;
using System.IO;
using System.Collections.Generic;
namespace SaveSortedNames
{
    class SaveNames
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\..\Files\file6.txt");
            List<string> listNames = new List<string>();

            using (reader)
            {
                string currentName = reader.ReadLine();
                while (currentName != null)
                {
                    listNames.Add(currentName);
                    currentName = reader.ReadLine();
                }
            }
            listNames.Sort();

            StreamWriter sortedFile = new StreamWriter(@"..\..\..\Files\file6.sorted.txt");
            using(sortedFile)
            {
                for(int i = 0 ; i < listNames.Count;i++)
                {
                    sortedFile.WriteLine(listNames[i]);
                }
            }

        }
    }
}
