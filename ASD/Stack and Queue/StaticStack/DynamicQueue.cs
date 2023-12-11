using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    internal class DynamicQueue<T>
    {
        class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Value { get; set; }
            public Node(T value)
            {
                Value = value;
            }

            public Node(T value, Node<T> next) : this(value)
            {
                Next = next;
            }
            public static bool operator ==(Node<T> left, T right)
            {
                return left.Value.Equals(right);
            }

            public static bool operator !=(Node<T> left, T right)
            {
                return !left.Value.Equals(right);
            }
        }

        Node<T> Head { get; set; }
        public int Count { get; private set; }

        public DynamicQueue()
        {

        }

        public DynamicQueue(T value)
        {
            Enqueue(value);
        }

        public DynamicQueue(IEnumerable<T> values)
        {
            foreach (var item in values)
            {
                Enqueue(item);
            }
        }

        public void Enqueue(T value)
        {
            if (Count == 0)
            {
                Head = new Node<T>(value);
            }
            else
            {

                Node<T> newNode = new Node<T>(value);
                Node<T> currentNode = Head;
                for (int i = 0; i < Count - 1; i++)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }
                Count++;
        }

        public T Dequeue()
        {
            T value = Head.Value;
            Head = Head.Next;
            Count--;
            return value;
        }

        public T Peek()
        {
            return Head.Value;
        }

        public void Clear()
        {
            Head = null;
            Count = 0;
        }
        public bool Contains(T value)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current == value) return true;
                current = current.Next;
            }
            return false;
        }
        public void Reverse()
        {
            var current = Head;
            var collection = new Collection<T>();
            while (current != null)
            {
                collection.Add(current.Value);
                current = current.Next;
            }
            current = Head;
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                current.Value = collection.ElementAt(i);
                current = current.Next;
            }
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (Count > array.Length) throw new Exception();
            var collection = new Collection<T>();
            var current = Head;
            while (current != null)
            {
                collection.Add(current.Value);
                current = current.Next;
            }
            for (int i = 0; i < Count; i++, arrayIndex++)
            {
                array[arrayIndex] = collection.ElementAt(i);
            }
        }
        public void Print()
        {
            Node<T> current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}
