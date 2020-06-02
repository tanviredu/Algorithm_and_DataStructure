using System;
using System.Collections.Generic;

namespace with_generic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Queue<string> q = new Queue<string>();
            q.Enqueue("one");
            q.Enqueue("two");
            q.Enqueue("three");
            q.Enqueue("four");
            q.Enqueue("five");
            
            foreach(var item in q){
                Console.WriteLine(item);
            }
            
            q.Dequeue();
            Console.WriteLine(q.Peek());
            q.Dequeue(); 
            Console.WriteLine(q.Peek());
        }
    }
}
