using System;
using System.Collections;
using System.Collections.Generic;
namespace scratch_implement{

    //linked list class goes here
    // it will be a generic class
    // inherit from the Icollctopn class
    public class linkedList<T> : ICollection<T>
    {
        
        // adding different node
        public LinkedListNode<T> Head {get;private set;}
        public LinkedListNode<T> Tail {get;private set;}
        
        // implemented property 
        public int Count{get;private set;}
        

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            // when this method call
            // we add this AddFirst() method
            AddFirst(item);
            
        }

        // it will take a node and add it
        // this is a implemented property
        private void AddFirst(LinkedListNode<T> node)
        {
            LinkedListNode<T> temp = Head;
            
            Head = node;
            
            // now head is the new value
            // and the second value
            // or the place holder of the head 
            // for the second value will be its previous value
            Head.Next = temp;
            // adding so increase the count
            Count++;
            
            // so if the list is empty
            // and now add so count is 1 
            // then you have only one element
            // so head is tail
            if(Count == 1){
                Tail = Head;
            }
            
        }
        // adding the override for supporting just value
        private void AddFirst(T value){
            // make it a node 
            // then add it
            AddFirst(new LinkedListNode<T>(value));
        }
    
    
    
    
    
    
        
    
    
        private void AddLast(LinkedListNode<T> node){
            if(Count == 0 ){
                // empty list
                // so node will be head
                Head = node;
            }else{
               
               // this is the current last node
                Tail.Next = node;
                 
            }
            // if the list is empty
            // then the node is the added as head
            // if it is not then
            // it will be added to the current last nodes pointer attribute
            // which is also a node object
            // then you need to tell that new node
            // that you are the tail now
            // you tail will be now assigned to the new node
            Tail = node;
            Count++;
            
        }
        private void AddLast(T value){
            AddLast(new LinkedListNode<T>(value));
        }
        
        
        
        
        
        
        public void RemoveFirst(){
            if(Count!=0){
                // change the pointer to the previous
                Head = Head.Next;
                Count--;
            }
            if(Count == 0){
                //if nothing in the list
                // then its alrady empty
                // but we still null the Tail
                // becayse tail = head = null
                Tail = null;
            }
        }
        
        
        public void RemoveLast(){
            if(Count!=0){
                if (Count == 1){
                    // there is only one element
                    // that means head ==Tail
                    // so we both null the value
                    Head = null;
                    Tail = null;
                }else{
                    // if it is more than 1
                    // then we need loop to
                    // Last and then null its 
                    // placeholder for the last
                    // before
                    //[1,2],[2,3],[3,4]
                    //after
                    //[1,2],[2,3],[3,null]
                    // and set the pointer
                    // that last is [3,null]
                    
                    
                    
                    // loop the chain
                    LinkedListNode<T> current = Head;
                    while(current.Next !=Tail){
                        current = current.Next;
                    }
                    // found the last
                    // now null its last placeholder
                    current.Next = null;
                    Tail = current;
                }
                Count--;
            }
        }
        
        
        
        
        
        
        
        
        public void Clear()
        {
            throw new NotImplementedException();
        }
        
        // it will tell if a value
        // is exists or not
        public bool Contains(T item)
        {
            LinkedListNode<T> current = Head;
            
            // search the whole list
            // this is bruteforce
            while(current !=null){
                if(current.Value.Equals(item)){
                    return true;
                }
                current = current.Next; 
               
            }
            return false;
            
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}    