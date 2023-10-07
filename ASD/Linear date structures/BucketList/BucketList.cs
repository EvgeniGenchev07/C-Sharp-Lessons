using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketList
{
    internal class BucketList<T> : IEnumerable<T>
    {
        private T[] buckets;
        private int capacity;
        private const int minCapacity = 4;
        private int lastIndex = 0;
        public BucketList()
        {
            capacity = minCapacity;
            buckets = new T[minCapacity];
        }
        public int Count => buckets.Length;
        public int Capacity => capacity;
        public T this[int index]
        {
            get { return buckets[index]; }
            set { buckets[index] = value; }
        }
        public void Add(T item)
        {
            if (capacity == lastIndex) Reserve();
            buckets[lastIndex] = item;
            lastIndex++;

        }
        public void Reserve()
        {
            T[] newBuckets = new T[capacity * 2];
            for (int i = 0; i < buckets.Length; i++)
            {
                newBuckets[i] = buckets[i];
            }
            capacity = capacity * 2;
            buckets = newBuckets;
        }
        public void Remove(int index)
        {
            lastIndex--;
            for (int i = index; i < lastIndex; i++)
            {
                int n = i;
                buckets[i] = buckets[n + 1];
            }
            buckets[lastIndex] = default(T);

        }
        public void Insert(int index, T item)
        {
            if (capacity == lastIndex) Reserve();
            T[] newBuckets = new T[capacity];
            for (int i = 0; i < lastIndex; i++)
            {
                newBuckets[i] = buckets[i];
            }
            for (int i = index; i < lastIndex; i++)
            {
                int n = i;
                buckets[n + 1] = newBuckets[i];
            }
            buckets[index] = item;
            lastIndex++;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < lastIndex; i++)
            {
                yield return buckets[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}



