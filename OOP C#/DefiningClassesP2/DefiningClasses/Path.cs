using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Path
    {
        private List<Point3D> points = new List<Point3D>();

        public Path()
        {
            this.points = new List<Point3D>();
           
        }
       
        public int Count
        {
            get
            {
                return this.points.Count;
            }
        }

       public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }


       public Point3D this[int index]
       {
           get
           {
               return this.points[index];
           }
           set
           {
               this.points[index] = value;
           }
       }

    }
}
