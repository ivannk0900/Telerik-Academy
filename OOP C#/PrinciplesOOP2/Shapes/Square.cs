using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Shape
    {
        public Square(double length)
            :base(length)
        {
            this.Width = length;
            this.Height = length;
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
