using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Linear_date_structures
{
    public class Queue<T>
    {
        private T[] buffer;
        private const int minCapacity = 4;
        private int size;
        private int startIndex;
        private int endIndex
        {
            get
            {
                int index = startIndex + size;
                if(index >= buffer.Length) index-=buffer.Length;
                return index;
            }
        }
        public Queue()
        {
            buffer = null;
            size = 0;
            startIndex = 0;
            //endIndex = 0;
        }
        public void Push(T item)
        {
            if (buffer == null)
            {
                buffer = new T[minCapacity];
            }
            else if (buffer.Length == size)
            {
                Reserve(size * 2);
            }
            buffer[endIndex] = item;
            //endIndex = NextIndex(endIndex);
            ++size;
        }
        public void Pop()
        {
            buffer[startIndex] = default(T);
            startIndex = NextIndex(startIndex);
            --size;
        }
        public T Front => buffer[startIndex];
        public int Size => size;
        public int Capacity => buffer.Length;
        public bool Empty => size == 0;
        private int NextIndex(int index)
        {
            ++index;
            if (index == buffer.Length)
            {
                index = 0;
            }
            return index;
        }
        private void Reserve(int newSize)
        {
            if (newSize < size) { return; }
            var newBuffer = new T[newSize];
            for (int i = 0,j = startIndex; i < size; j=NextIndex(j),i++)
            {
                newBuffer[i] = buffer[j];
            }
            startIndex = 0;
            //endIndex=size;
            buffer = newBuffer;
        }
    }
}
