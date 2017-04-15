using System;
using System.Collections.Generic;

namespace SearchingAlgorithms
{

    public class QuickSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            this.QuickSort(collection, 0, collection.Count - 1);
        }

        private void QuickSort(IList<T> elements, int left, int right)
        {
            int i = left, j = right;
            T pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    T tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                QuickSort(elements, left, j);
            }

            if (i < right)
            {
                QuickSort(elements, i, right);
            }
        }

    }
}
