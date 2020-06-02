namespace scratch_implement
{
    public class LinkedListNode<T>
    {
        
        // we made a generic class
        // to accept kinds of value
        // no matter it is string or int or float
        // we  define a node
        // Node contains a value
        // and a field for other node
        
        public T Value{get;set;}
        public LinkedListNode<T> Next {get;set;}
        public LinkedListNode(T value) =>
            //init the value when the class init 
            Value = value;
    }
}

