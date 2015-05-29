using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmProblem
{
   public class Display
    {
        private int size;
        private int colours;

        public Display()
        {
            this.size = 0;
            this.colours = 0;
        }
        public Display(int size, int colours)
        {
            this.size = size;
            this.colours = colours;
        }

        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        public int Colours
        {
            get
            {
                return this.colours;
            }
            set
            {
                this.colours = value;
            }
        }
    }
}
