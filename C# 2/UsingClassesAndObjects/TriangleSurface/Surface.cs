using System;

namespace TriangleSurface
{
    class Surface
    {
        static double Altitude(double a,double altitude)
        {
            return (a * altitude) / 2;
        }
        static double Sides(double a ,double b ,double c)
        {
            double p = a + b + c;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        static double sin(double a, double b ,double angle)
        {
            return (a * b * Math.Sin(angle)) / 2;
        }
        static void Main()
        {
            Console.WriteLine("for side and altitude press 1");
            Console.WriteLine("for three sides press 2");
            Console.WriteLine("for two sides and angle press 3");

            int choise = int.Parse(Console.ReadLine());
            if(choise==1)
            {
                Console.WriteLine("enter side");
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine("enter altitude");
                double altitude = double.Parse(Console.ReadLine());
                Console.Write("the triangle surface is: ");
                Console.Write(Altitude(side, altitude));
                Console.WriteLine();
            }
            else if(choise==2)
            {
                Console.WriteLine("enter 3 sides");
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double side3 = double.Parse(Console.ReadLine());
                Console.Write("the triangle surface is: {0}",Sides(side1,side2,side3));
            }
            else if(choise==3)
            {
                
                Console.WriteLine("enter 2 sides");
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("enter angle");
                double angle=double.Parse(Console.ReadLine());
                Console.Write("the triangle surface is: {0}", sin(side1,side2,angle));

            }
        }
    }
}
