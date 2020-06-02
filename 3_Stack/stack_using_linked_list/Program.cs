using System;

namespace stack_using_linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);
            st.Push(6);
            st.Pop();
            st.Pop();
            foreach(var i in st){
                Console.Write($"{i} ");
            }
            
            Console.WriteLine();
            Console.WriteLine(st.Peek());
            
        }
    }
}
