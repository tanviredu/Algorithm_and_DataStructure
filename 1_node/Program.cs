using System;

namespace _1_node
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            
            
           // creating three independent node 
            
            Node first = new Node();
            first.Value =3;
            
            
            Node second = new Node();
            second.Value = 5;
            
            Node third = new Node();
            third.Value = 10;
            
            
            // adding the send node
            // to the first nodes Next placeholder
            // to make a connection
            first.Next = second;
            second.Next = third;
            
            
            
            
            PrintChain(first); // this is the starting of the chain
            
            
            
            
        }

        private static void PrintChain(Node node)
        {
            while(node != null){
                Console.Write($"Node {node.Value,2}");
                node = node.Next;
                Console.Write($" -----> ");   
            }

        }
        
        
       
        
        
        
    }
}
