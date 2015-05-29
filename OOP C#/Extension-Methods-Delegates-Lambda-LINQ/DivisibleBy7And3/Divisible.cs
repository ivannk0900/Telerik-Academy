using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy7And3
{
    class Divisible
    {
        static void Main()
        {
            int n = 100;
            var arr = new int[n]; 
            for(int i = 0 ; i < n; i ++)
            {
                arr[i] = i;
            }
            Console.WriteLine("array with numbers from 0 to 99 was created");

            var divisibleArr =  arr.Where(x=>x%3==0&&x%7==0);

            Console.WriteLine("(extension method)the divisible numbers are : {0}",String.Join(", ",divisibleArr));


            var divisibleArr2 =
                from num in arr
                where num % 3 == 0 & num % 7 == 0
                select num;

            Console.WriteLine("(Linq)the divisible numbers are : {0}", String.Join(", ", divisibleArr2));


        }
    }
}
