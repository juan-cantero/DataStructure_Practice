using System;
namespace Datastructure_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new Array<Int32>();
            array.Add(2);
            array.Add(3);
            Console.WriteLine(array.IndexOf(3));
        }
    }
}
