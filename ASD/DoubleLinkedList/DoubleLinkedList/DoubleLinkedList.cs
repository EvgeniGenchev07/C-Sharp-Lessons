using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    internal class DoubleLinkedList<T>
    {
        class Node<T>
        {
            public T Value;
            public Node<T> Next { get; set; }
            public Node<T> Before { get; set; }
            public Node(T value)
            {
                Value = value;
            }
            public Node(T value, Node<T> next)
                : this(value)
            {
                Next = next;
            }
            public Node(T value, Node<T> next, Node<T> before)
                : this(value, next)
            {
                Before = before;
            }
        }
        Node<T> Head { get; set; }
        Node<T> Tail { get; set; }
        public int Count { get; private set; }
        public DoubleLinkedList()
        {
        }
        public DoubleLinkedList(T value)
        {
            Head = Tail = new Node<T>(value);
            Count = 1;
        }
        public DoubleLinkedList(IEnumerable<T> collection)
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
                newNode.Before = Tail;
                Tail = newNode;
            }
            Count++;
        }

        public void AddRange(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public bool Contains(T value)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Value.Equals(value)) return true;
                current = current.Next; 
            }
            return false;
        }

        public void Clear()
        {
            Head = Tail = null;
            Count = 0;
        }

        public void CopyTo(IEnumerable<T> values, int index)
        {
            for (var i = index; i < values.Count(); i++)
            {
                var value = values.ElementAt(i);
                Add(value);
            }
        }

        public void Reverse()
        {
            var collection = new Collection<T>();
            var current = Tail;
            while (current != null)
            {
                collection.Add(current.Value);
                current = current.Before;
            }
            Clear();
            AddRange(collection);
        }

        public void Remove(T value)
        {
            if (Count == 0) throw new IndexOutOfRangeException();
            if (Head.Value.Equals(value))
            {
                Head = Head.Next;
                Head.Before = null;
            }
            else
            {
                Node<T> previousNode = null;
                Node<T> currentNode = Head;
                while (currentNode != null)
                {
                    if (currentNode.Value.Equals(value))
                    {
                        previousNode.Next = currentNode.Next;
                        if (previousNode.Next == null) Tail = previousNode;
                        else previousNode.Next.Before = previousNode;
                        break;
                    }
                    else
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.Next;
                    }
                }

            }
            Count--;
        }

        public void RemoveAt(int index)
        {
            if (Count <= index) throw new IndexOutOfRangeException();
            if (index == 0)
            {
                Head = Head.Next;
                Head.Before = null;
            }
            else
            {
                var previousNode = FindNodeAt(index);
                previousNode.Next = previousNode.Next.Next;
                if (previousNode.Next == null) Tail = previousNode;
                else previousNode.Next.Before = previousNode;
            }
            Count--;
        }

        public void InsertAt(T value, int index)
        {
            if (Count < index) throw new IndexOutOfRangeException();
            Node<T> newNode = new Node<T>(value);
            if (index == 0)
            {
                newNode.Next = Head;
                Head.Before = newNode;
                Head = newNode;
                Head.Before = null;
            }
            else
            {
                var previousNode = FindNodeAt(index);
                newNode.Next = previousNode.Next;
                if (newNode.Next == null) Tail = newNode;
                else newNode.Next.Before = newNode;
                previousNode.Next = newNode;
                newNode.Before = previousNode;

            }
            Count++;
        }
        public void Print()
        {
            var node = Head;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
        public void PrintReverse()
        {
            var node = Tail;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Before;
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
