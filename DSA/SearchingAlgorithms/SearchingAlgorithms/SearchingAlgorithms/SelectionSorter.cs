namespace SearchingAlgorithms
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                T min = collection[i];


                for (int j = i + 1; j < collection.Count; j++)
                {

                    if (min.CompareTo(collection[j]) > 0)
                    {

                        T temp = collection[i];
                        collection[i] = collection[j];
                        collection[j] = temp;
                    }
                }

            }
        }
    }
}
