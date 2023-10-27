using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticStack
{
    internal class StaticStack<T>
    {
        T[] buffer { get; set; }
        public int Capacity => buffer.Length;
        const int Min_Capacity = 4;
        public int Count { get; private set; }
        public StaticStack() {
            buffer = new T[Min_Capacity];
        }

        public StaticStack(int capacity)
        {
            buffer = new T[capacity];
        }
        public StaticStack(T[] buffer)
        {
            buffer = new T[Min_Capacity];
            for (int i = 0; i < buffer.Length; i++)
            {
                Push(buffer[i]);
            }
        }

        public void Push(T item)
        {
            if (Count == Capacity) Resize();
            buffer[Count] = item;
            Count++;
        }

        public T Pop()
        {
            Count--;
            var value = buffer[Count];
            buffer[Count] = default(T);
            return value;
        }

        public T Peek()
        {
            return buffer[Count-1];
        }


        public bool Contains(T item)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                if (buffer[i].Equals(item)) return true;
            }
            return false;
        }

        public void Clear()
        {
            buffer = new T[Min_Capacity];
            Count = 0;
        }

        public void Reverse()
        {
            var newBuffer = new T[Count];
            for (int i = 0,j = Count-1; i < Count; i++,j--)
            {
                newBuffer[i] = buffer[j];
            }
            buffer = newBuffer;
        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            if(Count > array.Length) throw new Exception();
            for(int i = 0;i < Count;i++,arrayIndex++) 
            {
                array[arrayIndex] = buffer[i];
            }
        }

        void Resize()
        {
            var newBuffer = new T[Capacity * 2];
            for (int i = 0; i < buffer.Length; i++)
            {
                newBuffer[i] = buffer[i];
            }
            buffer = newBuffer;
        }

    }
}
