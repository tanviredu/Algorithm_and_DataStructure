using System;
using System.Collections.Generic;


namespace with_csharp{
public class BinaryTree{
    
    // very easy if you understand the concept
    // of inorder traversal
    
    
    
        public Node root;
        
        public virtual void inorder(){
            if(this.root == null){
                return;
            }
            
            // if root exists
            // we create a stacj
            Stack<Node> s = new Stack<Node>();
            // for looping pull the root
            Node curr = root;
            
        while (curr!=null || s.Count >0 ){
            // now we loop
            while(curr !=null ){
                // just go to the left
                //just left
                s.Push(curr);
                // change the pointer to the left
                curr = curr.left;
                
            }
            
            // so we got all the end now
            // end of the left node
            // now lets get back to to the one step back
            // to the parent 
            curr = s.Pop();
            Console.WriteLine(curr.data + " ");
            
            
            //and start going right
            
            curr = curr.right;
            
        }
        }
}
}
