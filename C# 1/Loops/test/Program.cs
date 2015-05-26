using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string p = "1231";
            int a = int.Parse(p);
            string c = Convert.ToString(a, 2);
            Console.WriteLine(c);
            
        }
    }
}
