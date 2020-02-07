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

        static void Main(string[] args)
        {
            bool isBalanced = IsBalancedExpression("[}]{[1]}");
            Console.WriteLine(isBalanced);

        }
    }
}
