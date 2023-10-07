using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyClasses
{
    public static class Range
    {
        public static Lazy<List<int>> FromTo(Lazy<int> start, Lazy<int> end)
        {
            if (start.Value >= end.Value)
            {
                return new Lazy<List<int>>(() => new List<int>());
            }
            var nextValue = new Lazy<int>(() => start.Value + 1);
            var list = new List<int>(start, FromTo(nextValue, end));
            return new Lazy<List<int>>(() => list);
        }
        public static Lazy<List<int>> From(Lazy<int> start)
        {

            var nextValue = new Lazy<int>(() => start.Value + 1);
            var list = new List<int>(start, From(nextValue));
            return new Lazy<List<int>>(() => list);
        }
        public static Lazy<List<T>> FromIEnumerable<T>(this IEnumerable<T> values)
        {
            return FromIEnumerator(values.GetEnumerator());
        }
        private static Lazy<List<T>> FromIEnumerator<T>(this IEnumerator<T> enumerator)
        {
            if(!enumerator.MoveNext()) return new Lazy<List<T>>(()=>new List<T>());
            var headValue =new Lazy<T>(()=> enumerator.Current);
            var list = new List<T>(headValue,FromIEnumerator(enumerator));
            return new Lazy<List<T>>(()=>list);
        }
    }
}
