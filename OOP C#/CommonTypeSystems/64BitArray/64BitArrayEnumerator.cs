using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64BitArray
{
    public class _64BitArrayEnumerator : IEnumerator<int>
    {
        private int index;
        private int[] array;
        public _64BitArrayEnumerator(int[] arr)
        {
            this.array = arr;
            this.index = -1;

        }
        public long Current
        {
            get { return this.array[this.index]; }
        }

        public void Dispose()
        {
        }

        object System.Collections.IEnumerator.Current
        {
            get { return this.Current; }
        }

        public bool MoveNext()
        {
            if(this.index>=array.Length)
            {
                return false;
            }
            this.index++;
            return true;
        }

        public void Reset()
        {
            this.index = 0;
        }
    }
}
