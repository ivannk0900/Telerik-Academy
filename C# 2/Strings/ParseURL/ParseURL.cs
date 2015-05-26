using System;
using System.Text;

namespace ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            string input = "http://telerikacademy.com/Courses/Courses/Details/212";

            int indexOfDoubleDots = input.IndexOf("://");
            int indexOfForwardSlashAfterServer = input.IndexOf("/", indexOfDoubleDots + 3);
            StringBuilder protocol = new StringBuilder();
            StringBuilder server = new StringBuilder();
            StringBuilder resource = new StringBuilder();
            for (int i = 0; i < indexOfDoubleDots; i++)
            {
                protocol.Append(input[i]);
            }
            for(int i = indexOfDoubleDots+3;i<indexOfForwardSlashAfterServer;i++)
            {
                server.Append(input[i]);
            }
            for(int i = indexOfForwardSlashAfterServer; i < input.Length;i++)
            {
                resource.Append(input[i]);
            }
            Console.WriteLine("[protocol] = {0}",protocol);
            Console.WriteLine("[server] = {0}",server);
            Console.WriteLine("[resourse] = {0}",resource);
        }
    }
}
