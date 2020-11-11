using System;
using System.Collections.Generic;

namespace WachtrijenEnStapels2
{
    class Program
    {
        static void Main()
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("a");
            q.Enqueue("b");
            q.Enqueue("c");

            Console.WriteLine(q.Peek());    // "a"
            Console.WriteLine(q.Count);     //  3

            Console.WriteLine(q.Dequeue()); // "a"
            Console.WriteLine(q.Count);     //  2

            q.Clear();
            Console.WriteLine(q.Count);     //  0

            Stack<string> s = new Stack<string>();
            s.Push("a");
            s.Push("b");
            s.Push("c");

            Console.WriteLine(s.Peek());    // "c"
            Console.WriteLine(s.Count);     //  3

            Console.WriteLine(s.Pop());     // "c"
            Console.WriteLine(s.Count);     //  2

            s.Clear();
            Console.WriteLine(s.Count);     //  0
        }

    }
}
