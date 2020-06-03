using System;

namespace with_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var pq = new  PriorityQueue<int>();
            pq.Enqueue(10);
            pq.Enqueue(20);
            pq.Enqueue(30);
            pq.Enqueue(2);
            pq.Enqueue(100);
            pq.Enqueue(1);
            
            foreach(var item in pq){
                Console.Write($"{item} ");
            }
        }
    }
}
