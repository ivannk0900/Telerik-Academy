using System;
using System.Text;

namespace StringLength
{
    class StrLength
    {
        static void Main()
        {
            Console.WriteLine("enter the string");
            StringBuilder str = new StringBuilder(Console.ReadLine());

            if(str.Length>20)
            {
                Console.WriteLine("the string is more than 20 characters");
            }
            else if (str.Length==20)
            {
                Console.WriteLine(str);
            }
            else if(str.Length<20)
            {
                int difference = 20 - str.Length;
               for(int i = 0 ; i<difference;i++)
               {
                   str.Append('*');
               }
            }

            Console.WriteLine(str);
        }
    }
}
