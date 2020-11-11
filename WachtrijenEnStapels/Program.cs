using System;
using System.Collections.Generic;

namespace WachtrijenEnStapels
{
     class Program
    {
        static void Main()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            PrintQueue(q); // 1 2 3 -> in volgorde van toevoegen en dequeue'en

            Stack<string> s = new Stack<string>();
            s.Push("a");
            s.Push("b");
            s.Push("c");
            PrintStack(s); // c b a -> in volgorde van pop'pen, omgekeerde volgorde van toevoegen
        }
        static void PrintQueue(Queue<int> queue)
        {
            foreach (int element in queue) Console.Write(element.ToString() + " ");
            Console.WriteLine();
        }
        static void PrintStack(Stack<string> stack)
        {
            foreach (string element in stack) Console.Write(element.ToString() + " ");
            Console.WriteLine();
        }
    }

}

