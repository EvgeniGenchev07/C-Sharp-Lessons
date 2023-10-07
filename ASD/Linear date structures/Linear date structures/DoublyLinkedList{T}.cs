using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_date_structures
{
    public class DoublyLinkedList<T>
    {
        public DoublyLinkedList()
        {
            First = null;
            Last = null;
            Size = 0;
        }
        public int Size { get; private set; }
        public DoublyLinkedNode<T> First { get; private set; }
        public DoublyLinkedNode<T> Last { get; private set; }
        public void PushFront(T item)
        {
            if (First == null)
            {
                ++Size;
                Last = First = new DoublyLinkedNode<T>(item);
                return;
            }
            InsertBefore(First, item);
        }
        public void PushBack(T item)
        {
            if (Last == null)
            {
                ++Size;
                Last=First = new DoublyLinkedNode<T>(item);
                return;
            }
            InsertAfter(Last,item);
        }
        public void PopFront()
        {
            Remove(First);
        }
        public void PopBack()
        {
            Remove(Last);
        }
        public void Remove(DoublyLinkedNode<T> node)
        {
            if(node.Prev != null)node.Prev.Next = node.Next;
            else First= node.Next;
            if(node.Next!=null)node.Next.Prev = node.Prev;
            else Last= node.Prev;
            --Size;
        }
        public void InsertBefore(DoublyLinkedNode<T> node, T item)
        {
            Size++;
            var newNode = new DoublyLinkedNode<T>(item);
            newNode.Prev = node.Prev;
            if(node.Prev!=null) node.Prev.Next = newNode;
            else First= newNode;
            node.Prev = newNode;
            newNode.Next = node;
        }
        public void InsertAfter(DoublyLinkedNode<T> node, T item)
        {
            Size++;
            var newNode = new DoublyLinkedNode<T>(item);
            newNode.Prev = node;
            newNode.Next = node.Next;
            node.Next = newNode;
            if (node.Next.Next != null) node.Next.Next.Prev = newNode;
            else Last = newNode;
        }
    }

}
