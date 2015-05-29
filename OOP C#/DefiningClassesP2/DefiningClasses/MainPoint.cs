using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class MainPoint
    {
        static void Main()
        {


            GenericList<int> list = new GenericList<int>();
            
            list.Add(1);
            list.Add(2);
            list.Add(3);

      //      list.RemoveAt(0);
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            
           

        }
    }
}
