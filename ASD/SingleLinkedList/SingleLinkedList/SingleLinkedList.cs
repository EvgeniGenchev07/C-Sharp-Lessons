using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    internal class SingleLinkedList<T>
    {
        class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }
            public Node(T value)
            {
                Value = value;
            }
            public Node(T value, Node<T> next)
                : this(value)
            {
                Next = next;
            }
        }
        Node<T> Head { get; set; }
        Node<T> Tail { get; set; }
        public int Count { get; private set; }
        public SingleLinkedList()
        {
        }
        public SingleLinkedList(T value)
        {
            Head = Tail = new Node<T>(value);
            Count = 1;
        }
        public SingleLinkedList(IEnumerable<T> collection)
        {
            AddRange(collection);
        }
        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (Count == 0) Head = Tail = newNode;
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Add(item);
            }
        }

        public void Remove(T value)
        {
            if (Count == 0) throw new IndexOutOfRangeException();
            if (Head.Value.Equals(value)) Head = Head.Next;
            else
            {
                Node<T> previousNode = null;
                Node<T> currentNode = Head;
                while (currentNode != null)
                {
                    if (currentNode.Value.Equals(value))
                    {
                        previousNode.Next = currentNode.Next;
                        break;
                    }
                    else
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.Next;
                    }
                }
                if (previousNode.Next == null) Tail = previousNode;
            }
            Count--;
        }

        public void RemoveAt(int index)
        {

            if (index == 0) Head = Head.Next;
            else
            {
                var previousNode = FindNodeAt(index);
                previousNode.Next = previousNode.Next.Next;
                if (previousNode.Next == null) Tail = previousNode;
            }
        }

        public void InsertAt(T value, int index)
        {
            if (Count < index) throw new IndexOutOfRangeException();
            Node<T> newNode = new Node<T>(value);
            if (index == 0)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                var previousNode = FindNodeAt(index);
                newNode.Next = previousNode.Next;
                previousNode.Next = newNode;
                if (newNode.Next == null) Tail = newNode;
            }
            Count++;
        }

        public bool Contains(T item)
        {
            var currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Value.Equals(item)) return true;
                currentNode = currentNode.Next;
            }
            return false;
        }

        public void CopyTo(IEnumerable<T> collection, int index)
        {
            for (int i = index; i < collection.Count(); i++)
            { 
                var item = collection.ElementAt(i);
                Add(item);
            }
        }

        public void Clear()
        {
            Head = Tail = null;
            Count = 0;
        }

        public void Reverse()
        {
            var collection = new Collection<T>();
            var currentNode = Head;
            while (currentNode != null)
            {
                collection.Add(currentNode.Value);
                currentNode = currentNode.Next;
            }
            Clear();
            AddRange(collection.Reverse());
        }

        public void Print()
        {
            var current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        Node<T> FindNodeAt(int index)
        {
            var previousNode = Head;
            for (int i = 1; i < index; i++)
            {
                previousNode = previousNode.Next;
            }
            return previousNode;
        }
    }
}
