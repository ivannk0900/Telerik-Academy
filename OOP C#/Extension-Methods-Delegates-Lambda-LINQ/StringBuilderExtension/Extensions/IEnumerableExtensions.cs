using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderExtension.Extensions
{
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection)
                               where T : IConvertible, IComparable
        {

            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }
            dynamic sum = 0;
            foreach (var element in collection)
            {
                sum += element;
            }
                
            return sum;
        }

        public static T Product<T> (this IEnumerable<T> collection) where T : IComparable, IConvertible
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }

            dynamic product = 1;
            foreach(var element in collection)
            {
                product *= element;
            }
            return product;
        }

        public static T Min<T> (this IEnumerable<T> collection) where T : IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }

            dynamic min = collection.First();

            foreach(var item in collection)
            {
                if (item.CompareTo(min) < 0)
                    min = item;
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }

            dynamic max = collection.First();

            foreach (var item in collection)
            {
                if(item.CompareTo(max)>0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static T Average<T> (this IEnumerable<T> collection) where T : IComparable
        {
            if (collection.Count() == 0)
            {
                throw new ArgumentException("The collection is empty!");
            }
            dynamic average = 0.0;

            foreach (var item in collection)
            {
                average += item;
            }
            return (average / collection.Count());

        }
    }
}
