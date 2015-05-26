using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a= ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b= ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c= ");
        double c = double.Parse(Console.ReadLine());

        if(a==0)
        if(b==0)
        if(c==0)
            {
                Console.WriteLine("Every x1 and x2 are solutions");
            }
                          else
                          {
                              Console.WriteLine("no solutions");
                          }
                 else
                {
                    Console.WriteLine("one solution: x1={0}",(double)-c/b);
                }
        else
        {
            double d = b * b - 4.0 * a * c;
            if (d < 0) Console.WriteLine("no real roots");
            else 
            {
                double x1 = (double)((-b + Math.Sqrt(d)) / (double)(2 * a));
                double x2 = (double)((-b - Math.Sqrt(d)) / (double)(2.0 * a));
                Console.WriteLine("x1= "+x1);
                Console.WriteLine("x2= " + x2);
            }
        }
        
        
    }
}

