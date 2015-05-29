using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtension
{
    public static class SBExtension
    {
        public static StringBuilder Substring(this StringBuilder input, int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();
            if(startIndex>input.Length||input.Length-startIndex<length)
            {
                throw new ArgumentOutOfRangeException("Index was outside of the bounds");
            }
            for (int i = startIndex; i <= length; i++)
            {
                result.Append(input[i]);
            }
            return result;

        }

    }
}
