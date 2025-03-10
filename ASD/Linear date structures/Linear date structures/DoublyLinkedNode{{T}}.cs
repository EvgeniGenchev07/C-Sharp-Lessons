﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_date_structures
{
    public class DoublyLinkedNode<T>
    {
        public T Value { get; internal set; }
        public DoublyLinkedNode<T> Prev {  get; internal set; }
        public DoublyLinkedNode<T> Next {  get;internal set; }
        internal DoublyLinkedNode(T value)
        {
            Value = value;
        }
    }
}
