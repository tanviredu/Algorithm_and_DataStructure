// we implement 
// the Ienumrable so we can 
// iterate through it and use it as a collection
// use the generic collection so it will accept any types value


/*
REMEMBER THE QUEUE IS THE FIRST COME FIRST OUT
*/








using System;
using System.Collections.Generic;
using System.Collections;

namespace stack_using_linked_list
{
   public class Stack<T>:IEnumerable<T>{
        
        // we init the generic Linked List collection
       private System.Collections.Generic.LinkedList<T> _list = 
            new System.Collections.Generic.LinkedList<T>();
        
        public void Push(T item){
            // this is the first come first out
            // we add the first
            _list.AddFirst(item);
        }
        
        public T Pop(){
            
            if(_list.Count == 0){
                
                throw new InvalidOperationException("The statck is empty");
            }
            
            // this is first out so we take the firstelement
            // this is first out
            T value = _list.First.Value;
            _list.RemoveFirst();
            
            // now return the first
            return value;
            
        }  
        
        public T Peek(){
            // return the first value
            // return the first value
            if(_list.Count == 0){
                throw new InvalidOperationException("This stack is empty");
            }
            return _list.First.Value;
        }     
        
        public int Count{
            get{
                return _list.Count;
            }
        } 
        
        public void Clear(){
            _list.Clear();
        }
        
        
        // we also implement Ienumrable of t to make it iterable
        // in the name GetEnumrator()
        
        // this is the implemented class of the IEnumrable
        
        
        
        
        
        // any time you use the ICollection you have to implement
        // those
        public IEnumerator<T> GetEnumerator(){
            return _list.GetEnumerator();
        }
        
        // this is implemented class Ienumrable
        
        IEnumerator IEnumerable.GetEnumerator(){
            return _list.GetEnumerator();
        }
        
    }
}
