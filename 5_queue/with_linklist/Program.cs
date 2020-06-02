using System;

namespace _5_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new Queue<int>();
            Console.WriteLine("adding ");
            q.Enquque(1);
            Console.WriteLine("adding ");
            q.Enquque(2);
            Console.WriteLine("adding ");
            q.Enquque(3);
            Console.WriteLine("adding ");
            q.Enquque(4);
            
            foreach(var i in q){
                Console.Write($" ->{i} ");
                
            }
            Console.WriteLine();
            Console.WriteLine("removing ");
            q.Dequeue();
            
            foreach(var i in q){
                Console.Write($" ->{i} ");
                
            }
            Console.WriteLine();
            Console.WriteLine("removing ");
            q.Dequeue();
            
            foreach(var i in q){
                Console.Write($" ->{i} ");
                
            }
        }
    }
}
