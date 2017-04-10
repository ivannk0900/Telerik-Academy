using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());



            var queue = new Queue<int>();
            queue.Enqueue(n);
            Console.WriteLine(n);

            for(int i=0; i < 50/3; i++)
            {
                int lastElement = queue.Dequeue();

                int first = lastElement + 1;
                queue.Enqueue(first);
                Console.WriteLine(first);

                int second = 2 * lastElement + 1;
                queue.Enqueue(second);
                Console.WriteLine(second);

                int third = lastElement + 2;
                queue.Enqueue(third);
                Console.WriteLine(third);

            }

        }
    }
}
