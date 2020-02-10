using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStructure_Practice
{
    class QueueArray<T>
    {
        private T[] _list = new T[5];

        public int Size
        {
            get { return _list.Length; }
        }
        public int Front { get; private set; }
        public int Rear { get; private set; }

        public QueueArray()
        {
            Front = 0;
            Rear = 0;
        }

        public bool IsFull()
        {
            return (Front == 0 && Rear == Size) ||
                GetNextRearPos() == Front;
        }

        private int GetNextRearPos() =>
            (Rear + 1) % (Size );
        private int GetNextFrontPos() =>
            (Front + 1) % (Size );

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");
            Front = GetNextFrontPos();
            return _list[Front - 1];
        }

        public void Enqueue(T element)
        {
            if (IsFull())
                throw new InvalidOperationException("Queue is full");
            
            _list[Rear] = element;
            Rear = GetNextRearPos();
            

        }


        public bool IsEmpty()
        {
            return Front == Rear;
        }

        public void PrintQueue()
        {
            foreach (var element in _list)
                Console.WriteLine(element);

        }




    }
}
