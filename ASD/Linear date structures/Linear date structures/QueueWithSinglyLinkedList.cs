using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_date_structures
{
    public class QueueWithSinglyLinkedList<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
        }
        private Node head;
        private Node tail;
        public QueueWithSinglyLinkedList()
        {
            head = null;
            tail = null;
        }
        public T Front => head.Value;
        public bool Empty=> head == null;
        public void Push(T item)
        {
            var newNode = new Node();
            newNode.Value = item;
            newNode.Next = null;
            if (tail != null)
            {
                tail = newNode;
                tail.Next = newNode;
            }
            else
            {
                head = newNode; 
                tail = newNode;
            }
            
        }
        public void Pop()
        {
            if (head != null)
            {
                head = head.Next;
            }
            else Clean();
        }
        public void Clean()
        {
            head = null;
            tail = null;
        }
    }
}
