using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructure_Practice
{
   
    public class LinkList<E>
    {
        public class Node<E>
        {
           internal E element;
           internal Node<E> next;

            public Node()
            {
                next = null;

            }
            public Node(E element) : base()
            {

                this.element = element;
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
                yield return Head.element;
                Head = Head.next;
            } while (Head != null);
        }

        public void AddFirst(E element)
        {
            var nodeToBeAdded = CreateNodeToAdd(element);
            if (Size == 0) { Head = Tail = nodeToBeAdded; }
            else { nodeToBeAdded.next = Head; Head = nodeToBeAdded; }
            Size++;
        }

        public void AddLast(E element)
        {
            Node<E> nodeToAdd = CreateNodeToAdd(element);
            if (Size == 0)
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
                if (pointer.element.Equals(element)) return i;
                pointer = pointer.next;
                i++;
            }
            throw new Exception("no such element") ;

        }
    }
}
