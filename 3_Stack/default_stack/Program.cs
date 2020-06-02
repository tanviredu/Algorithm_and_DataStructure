using System;
using System.Collections.Generic;

namespace default_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            // init default stack
            Stack<string> numbers = new Stack<string>();
            numbers.Push("One");
            numbers.Push("Two");
            numbers.Push("Third");
            numbers.Push("Four");
            Console.WriteLine(numbers.Peek());
            numbers.Pop();
            numbers.Pop();
            foreach(var i in numbers){
                Console.WriteLine(i);
            }
        }
    }
    
    
}
