using System.Collections.Generic;
using System.Collections;
namespace _1_node
{
    public class Node /*:  IEnumerable*/{
        // this class contain a value for the node
        // and a node placeholder for connecting 
        // the next node
        public int Value {get;set;}
        public Node Next{get;set;}
        
        
        
        
        // this is extra added for making the chain iterable
        // this is not part of the main program
        // this is not used in this program 
        // but thsi is used for making anyhting do foreach loop
        // and you need to inherit from the Ienumrable
        
        
        //   IEnumerator IEnumerable.GetEnumerator()
        // {
        //    var current = new Node();
           
        //    while(current != null){
        //        yield return current.Value;
        //        current = current.Next;
        //    }
           
           
        // }
        
    }
}
