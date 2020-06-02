using System;

namespace scratch_implement
{
    class Program
    {
        static void Main(string[] args)
        {
            var lc = new linkedList<String>();
            lc.Add("1"); // this add meas adding last
            lc.Add("2");
            lc.Add("3");
            lc.Add("4");
            lc.Add("5");
            
            foreach(var i in lc){
                Console.Write($"{i}  ");
            }
            Console.WriteLine();
            
            lc.RemoveLast();
            
            foreach(var i in lc){
                Console.Write($"{i}  ");
            }
        }
    }
}

