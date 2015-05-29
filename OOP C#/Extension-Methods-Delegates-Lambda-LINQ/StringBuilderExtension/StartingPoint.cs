using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtension
{
    class StartingPoint
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            text.Append("some text");
            Console.WriteLine(text.Substring(0,3));

            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(2);
            Console.WriteLine(myList.Average());
            
        }
    }
}
