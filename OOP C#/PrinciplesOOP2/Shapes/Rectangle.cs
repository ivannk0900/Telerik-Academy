using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
         public Rectangle(double heigth,double width)
            : base(heigth,width)
          
        {
            this.Height = heigth;
            this.Width = width;
        }
        public override double CalculateSurface()
        {
            return Height * Width;
        }
    }
}
