using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class TimerMain
    {

        public static void TheMethod()
        {
            Console.WriteLine("The method has been executed");
        }

        static void Main()
        {
            Timer mytimer = new Timer(3);

            mytimer.AddMethod += TheMethod;

            mytimer.ExecuteMethods();


        }
    }
}
