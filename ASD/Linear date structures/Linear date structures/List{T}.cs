using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Linear_date_structures
{
    public class List<T>
    {
        private T[] buffer;
        private int size;
        private int minCapacity = 4;

        public List()
        {
            buffer = null;
            this.size = 0;
        }
        public int Size => size;
        public int Capacity => buffer.Length;
        public T this[int index]
        {
            get { return buffer[index]; }
            set { buffer[index] = value; }
        }
        public T Last
        {
            get { return buffer[size - 1]; }
            set { buffer[size - 1] = value; }
        }
        public void PushBack(T item)
        {
            if (buffer == null)
            {
                buffer = new T[minCapacity];
            }
            else if (buffer.Length == size)
            {
                Reserve(size * 2);
            }
            buffer[size] = item;
            size++;
        }
        public void Reserve(int newSize)
        {
            if (newSize < size) { return; }
            var newBuffer = new T[newSize];
            buffer.CopyTo(newBuffer, size);
            buffer = newBuffer;
        }
        public void PopBack()
        {
            if (size == 0) throw new ArgumentException("Poping from empty list");
            --size;
            buffer[size] = default(T);
        }
        public void RemoveAt(int index)
        {
            for (int i = index; i < size-1; i++)
            {
                buffer[i] = buffer[i+1];
            }
            PopBack();
        }
        public void RemoveRange(int start, int end)
        {
            int range = end - start;
            for (int i = start; i < size-range; i++)
            {
                buffer[i] = buffer[i + range];
            }
            for (int i = 0; i < range; i++)
            {
                PopBack();
            }
        }
        public void InsertAt(int index, T item)
        {
            if(index==size)
            {
                PushBack(item);
                return;
            }
            
            buffer[index] = item;
            for (int i = ++index; i < size; i++)
            {
                    buffer[i] = buffer[i+1];
            }
        }
        public void SthrinkToFit()
        {
            Reserve(size);
        }
        public void Clear()
        {
            size = 0;
            buffer = new T[minCapacity];
        }
    }
}
