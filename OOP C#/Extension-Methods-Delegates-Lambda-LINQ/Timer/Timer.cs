using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    class Timer
    {

        public delegate void MyDelegate();

        public MyDelegate AddMethod { get; set; }
        public int Interval { get; set; }

        public Timer(int seconds)
        {
            this.Interval = seconds;
        }

        public void ExecuteMethods()
        {
            while (true)
            {
                this.AddMethod();
                Thread.Sleep(this.Interval * 1000); 
            }
        }
    }
}
