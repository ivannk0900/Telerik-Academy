using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapesMain
    {
        static void Main()
        {
            Shape[] figuresArr = new Shape[]
            {
                new Triangle(2,2),
                new Rectangle(3,2),
                new Square(3)
            };

            foreach (var shape in figuresArr)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
