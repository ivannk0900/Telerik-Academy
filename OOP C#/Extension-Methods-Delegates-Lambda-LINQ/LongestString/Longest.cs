using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class Longest
    {
        static void Main()
        {
            
            string[] strArr = new string[5];
            strArr[0] = "abc";
            strArr[1] = "abcd";
            strArr[2] = "abcde";
            strArr[3] = "abcdef";
            strArr[4] = "abcd";
            var longest =
                from str in strArr
                orderby str.Length descending
                select str;

            Console.WriteLine("the longest string is : {0}",longest.FirstOrDefault());
        }
    }
}
