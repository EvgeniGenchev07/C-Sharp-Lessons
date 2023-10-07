using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Linear_date_structures
{
    public class StackWithSinglyLinkedList<T>
    {
        private Node<T> top;
        public StackWithSinglyLinkedList()
        {
            top = null;
        }
        //public Optional<T> Top => top ==null?new Optional<T>():new Optional<T>(top.Value);
        public T Top => top.Value;
        public void Push(T item)
        {
            var newNode = new Node<T>();
            newNode.Value = item;
            newNode.Next = top;
            top = newNode;
        }
        public bool Pop()
        {
            if (top != null)
            {
                top = top.Next;
                return true;
            }
            else return false;
        }
        public void Clean()
        {
            top = null;
        }
    }
}
