using System;
using System.Net;

namespace DownloadFile
{
    class Download
    {
        static void Main()
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png","ninja.png");
            }
            catch(NotSupportedException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch(ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch(WebException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch(UnauthorizedAccessException exc)
            {
                Console.WriteLine(exc.Message);
            }
            
        }
    }
}
