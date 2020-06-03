using System;
using System.Collections;
using System.Collections.Generic;

namespace with_linked_list
{
     public class PriorityQueue<T> : IEnumerable<T> where T:IComparable<T>
    {

        LinkedList<T> _items = new LinkedList<T>();
        
        
        public void Enqueue(T  item){
            if(_items.Count == 0){
                _items.AddLast(item);
            }else{
                
                var current = _items.First; // take the first of the chain to start looping
                
                // you need to inherot from the Icomparable to
                // activate the function I comparable
                
                while(current != null && current.Value.CompareTo(item) > 0){
                    
                    // it checks that if the value in the list
                    // is greater than the item
                    // if it is then check the next one
                    current = current.Next;

                    
                }
                // after looping through if it getis to the last
                if(current == null){
                    // gone through the last
                    _items.AddLast(item);
                }else{
                    // if any current item is lower than the 
                    // item we passed 
                    // means item is bigger than the current item in the list
                    // so we add the greater before the current low item
                    //it actually 
                    // sort in a Desecding wat
                    // big to small
                    
                    _items.AddBefore(current,item);
                    // items added before the current
                }
                
                
            }
        }
        
        public T Dequque(){
            if(_items.Count == 0){
                throw new InvalidOperationException("queue is empty");
            }
            
            
            T value = _items.First.Value;
            _items.RemoveFirst();
            return value;
        }
        
        public T Peek(){
            if(_items.Count == 0){
                throw new InvalidOperationException("The queue is empty");
            }
            
            return _items.First.Value; 
        }
        
        
        public int Count{
            get{
                return _items.Count;
            }
        }
        
        public IEnumerator<T> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}
