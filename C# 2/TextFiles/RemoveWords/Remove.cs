using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

namespace RemoveWords
{
    class Remove
    {
        static void Main()
        {
            try
            {
                string listedWords = @"\b" + String.Join("|",
                File.ReadAllLines(@"..\..\..\Files\file12ListedWords.txt")) + @"\b";
                using (StreamReader streamReader = new StreamReader(@"..\..\..\Files\file12text.txt"))
                {
                    using (StreamWriter streamWriter = new StreamWriter(@"..\..\..\Files\file12result.txt"))
                    {
                        string line = streamReader.ReadLine();
                        while (line != null)
                        {
                            streamWriter.WriteLine(Regex.Replace(line,
                            listedWords, String.Empty));
                            line = streamReader.ReadLine();
                        }
                        
                    }
                }
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
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
