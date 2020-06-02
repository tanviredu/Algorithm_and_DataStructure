using System;
using System.Collections;
using System.Collections.Generic;


namespace _5_queue
{
    
    // this will be applied using the 
    // LinkedList nethod
    
    // this is the first come first out
    // data added from oneside
    // pop from the other side
    // data will be added from the last
    // pulled out from the first
    
    
    public class Queue<T> : IEnumerable<T>{
        
        LinkedList <T> _items = new  LinkedList<T>();
        // this push is known as Enqueue
        
        public void Enquque(T item){
            _items.AddLast(item);
            
        }
        
        // pop known as Dequeue
        public T Dequeue(){
            if(_items.Count == 0){
                throw new InvalidOperationException("The queue is empty");
            }
            // otherwise take the first value
            
            T value = _items.First.Value;
            _items.RemoveFirst(); //remove it
            //then return it
            return value;
        }
        
        public T Pek(){
            if(_items.Count == 0){
                throw new InvalidOperationException("the queue is empty.");
            }
            return _items.First.Value;
        }
        
        public int Count{
            get{
                return _items.Count;
            }
        }
        
        public void Clear(){
            _items.Clear();
        }
        
        // last two method
        // that is interface implemetation
        
        public IEnumerator<T>GetEnumerator(){
            return _items.GetEnumerator();
        }
        
        IEnumerator IEnumerable.GetEnumerator(){
            return _items.GetEnumerator();
        } 
        
    }
}
