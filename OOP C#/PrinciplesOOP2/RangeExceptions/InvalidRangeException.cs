using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    public class InvalidRangeException<T> : ApplicationException
    {

        private T start;
        private T end;


        public InvalidRangeException(string msg)
            : base(msg)
        {

        }


        public InvalidRangeException(string msg, Exception innerEx)
            : base(msg, innerEx)
        {
        }

        public InvalidRangeException(string msg, T start, T end)
            : this(msg)
        {
            this.start = start;
            this.end = end;
        }
        public InvalidRangeException(string msg, Exception innerEx, T start, T end)
            : this(msg, innerEx)
        {
            this.start = start;
            this.end = end;
        }



        public T Start
        {
            get
            {
                return this.start;
            }
            private set
            {
                this.start = value;
            }
        }

        public T End
        {
            get
            {
                return this.end;
            }
            private set
            {
                this.end = value;
            }
        }

    }
}
