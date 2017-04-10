//Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulateNestedLoops
{
    class Program
    {
        public static void RecursiveExec(int iterations, int depthLevel, int[] values)
        {
            if (depthLevel == 0)
            {
                PrintValues(values);
                return;
            }

            for (int i = 1; i <= iterations; i++)
            {
                values[depthLevel - 1] = i;
                RecursiveExec(iterations, depthLevel - 1, values);
            }
        }

        private static void PrintValues(int[] values)
        {
            Console.WriteLine(string.Join(" ", values));
        }
        static void Main()
        {
            RecursiveExec(3, 3, new int[3]);
        }
    }
}
