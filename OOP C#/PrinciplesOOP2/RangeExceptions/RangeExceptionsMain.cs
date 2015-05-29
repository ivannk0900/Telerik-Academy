using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class RangeExceptionsMain
    {
        static void Main()
        {
            try
            {
                throw new InvalidRangeException<int>("Invalid input", 2, 50);
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                throw new InvalidRangeException<DateTime>("Invalid date", new DateTime(1981, 1, 1), DateTime.Now);
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
