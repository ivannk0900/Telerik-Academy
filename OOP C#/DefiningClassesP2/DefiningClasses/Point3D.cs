﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public struct Point3D
    {
        private static  Point3D startPoint;
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D StartPoint
        {
            get
            {
                return startPoint;
            }
        }
        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        static Point3D()
        {
            startPoint = new Point3D(0, 0, 0);
        }
      
        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Z = {2};", this.X, this.Y, this.Z);
        }

   
    }
}
