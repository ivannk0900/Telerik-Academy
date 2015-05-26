using System;
using System.IO;
namespace ReadFileContents
{
    class ReadFile
    {
        static void Main()
        {
            try
            {
                Console.Write("enter full path: ");
                string path = Console.ReadLine();

                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch(FileNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch(FileLoadException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch(NotSupportedException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch(UnauthorizedAccessException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch(ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch(IOException exc)
            {
                Console.WriteLine(exc.Message);
            }
        
        }
    }
}
