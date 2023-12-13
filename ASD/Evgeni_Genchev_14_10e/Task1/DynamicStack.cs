using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class DynamicStack<T>
    {
        class Node<T>
        {
            public T Value;
            public Node<T> Previous { get; set; }
            public Node(T value)
            {
                Value = value;

            }
            public Node(T value, Node<T> previous) : this(value)
            {
                Previous = previous;
            }
        }
        Node<T> Tail { get; set; }
        public int Count { get; private set; }

        public DynamicStack() { }
        public DynamicStack(T value)
        {
            Push(value);
        }
        public DynamicStack(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Push(item);
            }
        }
        public T Peek() => Tail.Value;
        
        public void Push(T value)
        {
            Tail = new Node<T>(value, Tail);
            Count++;
        }

        public T Pop()
        {
            T value = Tail.Value;
            Tail = Tail.Previous;
            Count--;
            return value;
        }
    }
}
