using System;

namespace ListImplementation
{
    internal class CustomStaticList<T>
    {
        T[] buffer;

        const int minCapacity = 4;

        public int Count { get; set; }

        public int Capacity => buffer.Length;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Capacity) throw new IndexOutOfRangeException();
                return buffer[index];
            }
            set
            {
                if (index < 0 || index >= Capacity) throw new IndexOutOfRangeException();
                buffer[index] = value;
            }
        }

        public CustomStaticList()
        {
            buffer = new T[minCapacity];
        }

        public CustomStaticList(int capacity)
        {
            buffer = new T[capacity];
        }

        public CustomStaticList(IEnumerable<T> collection)
        {
            buffer = new T[minCapacity];
            AddRange(collection);
        }

        public void Add(T item)
        {
            if (Count == Capacity) ReSize();
            buffer[Count] = item;
            Count++;
        }

        public void InsertAt(T value, int index)
        {
            if (Count == Capacity) ReSize();
            for (int i = Count; i > index; i--)
            {
                buffer[i] = buffer[i-1];
            }
            buffer[index] = value;
            Count++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            if (Count + collection.Count() > Capacity) ReSize();
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public void Remove(T item)
        {
            int index = IndexOf(item);
            if (index == -1)
            {
                throw new Exception();
            }
            RemoveAt(index);
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                buffer[i] = buffer[i + 1];
            }
            Count--;
        }

        public void Clear()
        {
            buffer = new T[minCapacity];
            Count = 0;
        }

        public bool Contains(T item)
        {
            return IndexOf(item) != -1;
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (buffer[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public int LastIndexOf(T item)
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                if (buffer[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Reverse()
        {
            var newBuffer = new T[Capacity];
            for (int i = Count - 1, j = 0; i >= 0; i--, j++)
            {
                newBuffer[j] = buffer[i];
            }
            buffer = newBuffer;
        }

        public void CopyTo(IEnumerable<T> collection)
        {
            for (int i = 0; i < collection.Count(); i++)
            {
                Add(collection.ElementAt(i));
            }
        }

        public void CopyTo(IEnumerable<T> collection, int index)
        {
            for (int i = index; i < collection.Count(); i++)
            {
                Add(collection.ElementAt(i));
            }
        }

        public void CopyTo(int index, IEnumerable<T> collection, int collectonIndex, int count)
        {
            for (int i = collectonIndex; i < collection.Count()+collectonIndex; i++,index++)
            {
                InsertAt(collection.ElementAt(i),index);
            }
        }

        void ReSize()
        {
            var newBuffer = new T[Capacity*2];
            for (var i = 0; i < Count; i++)
            {
                newBuffer[i] = buffer[i];
            }
            buffer = newBuffer;
        }
    }
}
