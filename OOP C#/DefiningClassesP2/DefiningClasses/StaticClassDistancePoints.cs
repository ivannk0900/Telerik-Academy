using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public static class StaticClassDistancePoints
    {
        public static double CalculateDistance(Point3D firstPoint , Point3D secondPoint)
        {
            double firstPointCalc = Math.Sqrt(firstPoint.X * firstPoint.X + firstPoint.Y * firstPoint.Y + firstPoint.Z * firstPoint.Z);
            double secondPointCalc = Math.Sqrt(secondPoint.X * secondPoint.X + secondPoint.Y * secondPoint.Y + secondPoint.Z * secondPoint.Z);
            return Math.Abs(firstPointCalc - secondPointCalc);
        }
    }
}
