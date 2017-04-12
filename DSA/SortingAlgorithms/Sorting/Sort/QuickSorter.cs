using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            QuickSort(collection, 0, collection.Count - 1);
        }

        private void QuickSort(IList<T> collection, int left, int right)
        {
            var pivot = collection[(left + right) / 2];

            var i = left;
            var j = right;

            while (i <= j)
            {
                while (collection[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (collection[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i > j)
                {
                    continue;
                }

                var temp = collection[i];
                collection[i] = collection[j];
                collection[j] = temp;

                i++;
                j--;
            }

            if (left < j)
            {
                this.QuickSort(collection, left, j);
            }

            if (i < right)
            {
                this.QuickSort(collection, i, right);
            }


        }
    }
}
