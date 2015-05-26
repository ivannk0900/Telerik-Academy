using System;
using System.IO;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;

namespace CountWords
{
    class Count
    {
        static void Main()
        {

            try
            {
                string[] listedWords = File.ReadAllLines(@"..\..\..\Files\file13words.txt");
                int[] counter = new int[listedWords.Length];
                using (StreamReader reader = new StreamReader(@"..\..\..\Files\file13text.txt"))
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        lineNumber++;
                        for (int index = 0; index < listedWords.Length; index++)
                        {
                            counter[index] += ((Regex
                            .Matches(line, @"\b" + listedWords[index] + @"\b").Count));
                        }
                        line = reader.ReadLine();
                    }
                }
                Array.Sort(counter, listedWords);
                using (StreamWriter writer = new StreamWriter(@"..\..\..\Files\file13result.txt"))
                {
                    for (int index = listedWords.Length - 1; index >= 0; index--)
                    {
                        writer.WriteLine("{0}: {1}", listedWords[index], counter[index]);
                    }
                    
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SecurityException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }




}

