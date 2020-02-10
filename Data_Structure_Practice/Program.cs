using DataStructure_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datastructure_Practice
{
    class Program
    {
        public static String InvertWord(string word)
        {
            var inverted = new StringBuilder();
            var wordStack = new Stack<char>();
            foreach (char w in word)
            {
                wordStack.Push(w);
            }
           
            foreach (char w in wordStack)
            {
                inverted.Append(w);
            }
            return inverted.ToString();
        }

        public static bool IsBalancedExpression(string expression)
        {
            bool isBalanced = true;
            var brackets = new Stack<char>();
            var bracketDictionary = new Dictionary<char, char>()
            {
                {'(',')' },
                {'[', ']' },
                {'{', '}' }
            };


            foreach (var character in expression)
            {
                if (isBalanced == false)
                    break;
                if (bracketDictionary.ContainsKey(character))
                    brackets.Push(character);

                else if (bracketDictionary.ContainsValue(character))
                    // dictionary[k] allows me to see the associate value property
                    isBalanced = bracketDictionary[brackets.Pop()].Equals(character);
            }
            if (brackets.Count > 0) isBalanced = false;
            return isBalanced;
            
        }

        public static Queue<int> Reverse(Queue<int> queue)
        {
            var tempList = new Stack<int>();
            for (int i = 0; i < queue.Count; i++)
            {
                var temp = queue.Dequeue();
                tempList.Push(temp);
            }
            while (tempList.Count > 0)
            {
                queue.Enqueue(tempList.Pop());
            }

            return queue;
        }



        static void Main(string[] args)
        {
            try
            {
                var queue = new QueueArray<int>();
                queue.Enqueue(4);
                queue.Enqueue(5);
                queue.Enqueue(6);
                Console.WriteLine(queue.Front + " " + queue.Rear +" " + queue.Size);
                Console.WriteLine(queue.IsFull());
                
                queue.Enqueue(33);
                queue.Enqueue(33);
                queue.Enqueue(33);
                Console.WriteLine("----------------");
                queue.PrintQueue();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                
            }



        }
    }
}
