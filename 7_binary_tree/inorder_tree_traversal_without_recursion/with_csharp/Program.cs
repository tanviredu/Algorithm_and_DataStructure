using System;
using System.Collections.Generic;
namespace with_csharp
{
    
    // read the inorder traversal its very easy to understand
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            
            
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.inorder();
        }
    }
}
