using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    internal class SingleLinkedList<T>
    {
        class Node<T>
        {
            public T Value;
            public Node<T> Next;
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
            foreach (var item in collection)
            {
                Add(item);
            }
        }
        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (Count == 0) Head = Tail = newNode;
            else if (Count == 1)
            {
                Tail = newNode;
                Head.Next = Tail;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            Count++;
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
                Node<T> previousNode = Head;
                for (int i = 1; i <= index - 1; i++)
                {
                    previousNode = previousNode.Next;
                }
                newNode.Next = previousNode.Next;
                previousNode.Next = newNode;
                if (newNode.Next == null) Tail = newNode;
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
    }
}
