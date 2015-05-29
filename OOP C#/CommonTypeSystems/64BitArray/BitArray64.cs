using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64BitArray
{
    public class BitArray64 : IEnumerable<int>
    {
      private ulong[] array;


      public IEnumerator<int> GetEnumerator()
      {
          return new BitArray64(this.array);
      }

      System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
      {
          return this.GetEnumerator();
      }
    }
}
