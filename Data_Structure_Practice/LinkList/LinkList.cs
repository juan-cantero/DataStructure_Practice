using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructure_Practice
{
   
    public class LinkList<E>
    {
        public class Node<T>
        {
           public T Element { get; set; }
           internal Node<T> next;

            public Node()
            {
                next = null;

            }
            public Node(T element) : base()
            {

                this.Element = element;
            }

        }
        public Node<E> Head { get; private set; }
        public Node<E> Tail { get; private set; }

        public int Size { get; private set; }

        public LinkList()
        {
            Head = new Node<E>();
            Tail = new Node<E>();
            Size = 0;
        }


        private Node<E> CreateNodeToAdd(E element)
        {
            return new Node<E>(element);
        }

        private void TraverseList(E element)
        {
            

        }

        public IEnumerable<E> GetList()
        {


            do
            {
                yield return Head.Element;
                Head = Head.next;
            } while (Head != null);
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }

        public void AddFirst(E element)
        {
            var nodeToBeAdded = CreateNodeToAdd(element);
            if (IsEmpty()) { Head = Tail = nodeToBeAdded; }
            else { nodeToBeAdded.next = Head; Head = nodeToBeAdded; }
            Size++;
        }

        public void AddLast(E element)
        {
            Node<E> nodeToAdd = CreateNodeToAdd(element);
            if (IsEmpty())
            {
                AddFirst(element);
            }
            else
            {
                Tail.next = nodeToAdd;
                Tail = nodeToAdd;
            }
            Size++;
        }

        public int IndexOf(E element)
        {
            int i = 0;
            var pointer = Head;
            while (pointer != null)
            {
                if (pointer.Element.Equals(element)) return i;
                pointer = pointer.next;
                i++;
            }
            throw new Exception("no such element") ;

        }

        public bool Contains(E element)
        {
            var pointer = Head;
            while (pointer != null)
            {
                if (pointer.Element.Equals(element)) return true;
                pointer = pointer.next;
            }
            return false;
        }

        public void RemoveFirst()
        {
            if (IsEmpty()) 
                throw new InvalidOperationException("The list is empty");
            var temp = Head;
            Head = Head.next;
            temp.next = null;
            Size--;
        }

        public void RemoveLast()
        {
            if (IsEmpty())
                throw new InvalidOperationException("The list is empty");
            var pointer = Head;
            if (Head == Tail)
            {
                Head = Tail = null;
                return;
            }
            while (!pointer.next.Element.Equals(Tail.Element))
            {
                pointer = pointer.next;
            }
            Tail = pointer;
            Tail.next = null;
            Size--;
        }

        public void ReverseList()
        {
            if (Size == 1) return;
            var prev = Head;
            var current = prev.next;
            while (current != null)
            {
                var next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            var temp = Head;
            Head = Tail;
            Tail = temp;
            Tail.next = null;
        }

        public E GetKthFromTheEnd(int k)
        {
            if (k < 0) 
                throw new ArgumentOutOfRangeException("It should be a positive number");

            var left = Head;
            var right = Head;

            for (int i = 0; i < k; i++)  
                right = right.next;

            while (right != Tail)
            {
                left = left.next;
                right = right.next;
            }

            return left.Element;
        }


    }
}
