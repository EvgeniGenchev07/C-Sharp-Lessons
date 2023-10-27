using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    internal class DynamicStack<T>
    {
        class Node<T>
        {
            public T Value;
            public Node<T> Previous;
            public Node(T value)
            {
                Value = value;
            }
            public Node(T value, Node<T> previous) : this(value)
            {
                Previous = previous;
            }

            public static bool operator ==(Node<T> node, T item)
            {
                return node.Value.Equals(item);
            }
            public static bool operator !=(Node<T> node, T item)
            {
                return !node.Value.Equals(item);
            }
        }

        public int Count { get; private set; }
        Node<T> Tail { get; set; }  
        public DynamicStack()
        {

        }

        public DynamicStack(T value)
        {
            Push(value);
        }

        public void Push(T value)
        {
            Tail = new Node<T>(value, Tail);
            Count++;
        }

        public T Pop()
        {
            var value = Tail.Value;
            Tail = Tail.Previous;
            return value;
        }

        public T Peek()
        {
            return Tail.Value;
        }

        public void Clear()
        {
            Tail = null;
            Count = 0;
        }

        public bool Contains(T value)
        {
            var current = Tail;
            while (current != null)
            {
                if (current == value)
                {
                    return true;
                }
                current = current.Previous;
            }
            return false;
        }

        public void Reverse()
        {
            var current = Tail;
            var collection = new Collection<T>();   
            while (current != null)
            {
                collection.Add(current.Value);
                current = current.Previous;
            }
            current = Tail;
            for (int i = collection.Count-1; i >= 0; i--)
            {
                current.Value = collection.ElementAt(i);
                current = current.Previous;
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (Count > array.Length) throw new Exception();
            var collection = new Collection<T>();
            var current = Tail;
            while (current != null)
            {
                collection.Add(current.Value);
                current = current.Previous;
            }
            for (int i = 0; i < Count; i++, arrayIndex++)
            {
                array[arrayIndex] = collection.ElementAt(i);
            }
        }
        public void Print()
        {
            var current = Tail;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Previous;
            }
        }
    }
}
