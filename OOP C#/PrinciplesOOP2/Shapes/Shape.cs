using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        private double width;
        private double height;
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public Shape(double lenth)
        {
            this.Width = lenth;
            this.Height = lenth;
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if(this.width<0)
                {
                    throw new ArgumentException("The width can not be less than zero");
                }
                this.width = value;

            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if(this.height<0)
                {
                    throw new ArgumentException("The height can not be lass than zero");
                }
                this.height = value;
            }
        }
        public virtual double CalculateSurface()
        {
            return 0.0;
        }
    }
}
