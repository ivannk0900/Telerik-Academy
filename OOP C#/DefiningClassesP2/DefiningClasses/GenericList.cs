using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class GenericList<T> where T : IComparable, new()
    {
        private T[] elements;
        private int index;
        private int capacity = 16;
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
            this.index = 0;
        }
        public GenericList()
        {
            this.capacity = Capacity;
        }
        public void Add(T element)
        {
            elements[this.index] = element;
            this.index++;
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.index)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    return this.elements[index];
                }
            }
            set
            {
                if (index >= 0 && index <= this.index)
                {
                    this.elements[index] = value;
                    this.index++;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
        }


        public T RemoveAt(int index)
        {
            if (index >= this.index || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                "Invalid index: {0}.", index));
            }
            T result = elements[index];
            for (int i = index; i < this.index - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.elements[this.index - 1] = new T();
            this.index--;
            return result;
        }

        public void Insert(int index, T element)
        {
            if (index > this.index || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format(
                "Invalid index: {0}.", index));
            }
            if (this.index == index)
            {
                this.Add(element);
                return;
            }
            if(this.index>=this.elements.Length-1)
            {
                DoubleSize();
            }

            for (int i = this.index; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[index] = element;

        }

        public void Clear()
        {
            this.Capacity = 16;
            this.capacity = 16;
            this.elements = new T[Capacity];
            this.index = 0;
            
        }

        public int FindElement(T value) 
        {
            int indexFound = -1;
            for(int i = 0 ; i <= this.index;i++)
            {
                if(this.elements[i].Equals(value))
                {
                    indexFound = i;
                    break;
                }
               
            }
            return indexFound;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for(int i = 0; i <this.index;i++)
            {
                result.Append(elements[i]);
                if (i < this.index - 1)
                {
                    result.Append(", ");
                }
            }
            return result.ToString();
        }

        private void DoubleSize() 
        {
            int newSize = this.elements.Length * 2;
            T[] newData = new T[newSize];
            for (int i = 0; i < this.index; i++)
            {
                newData[i] = this.elements[i];
            }
            this.elements = newData;
            this.Capacity *= 2;
        }

        public T Min()
        {
            T min = this.elements[0];

            for(int i = 1 ; i <= this.index;i++)
            {
                if(this.elements[i].CompareTo(min)<0)
                {
                    min = this.elements[i];
                }
            }
            return min;
        }

        public T Max()
        {
            T max = this.elements[0];
            for(int i = 1; i < this.index;i++)
            {
                if(this.elements[i].CompareTo(max)>0)
                {
                    max = this.elements[i];
                }
            }
            return max;

        }

    }
}
