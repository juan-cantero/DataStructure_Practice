using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure_Practice.Stack
{
    class Stack<T>
    {
        private readonly LinkedList<T> _internalStack = new LinkedList<T>();

        public void Push(T element)
        {
            _internalStack.AddLast(element);
        }

        public T Peek()
        {
            return _internalStack.Last.Value;
        }

        public T Pop()
        {
            T last = Peek();
            _internalStack.RemoveLast();
            return last;
        }

        public int Size()
        {
            return _internalStack.Count;
        }
    }
}
