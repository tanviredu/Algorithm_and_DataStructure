using System;
using System.Collections.Generic;
namespace generic_implement
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is the default doubleLinkedList
            var lc = new  System.Collections.Generic.LinkedList<int>();
            
            // adding data
            
            for(int i=0;i<=10;i++){
                lc.AddLast(i);
            }
            
            var data = lc.First.Next.Next;
            
            
            lc.AddAfter(data,100);
            foreach(var i in lc){
                Console.WriteLine(i);
            }
            
            // because this LinkedList is  double link List
            // we can add before too
            lc.AddBefore(data,100);
            foreach(var i in lc){
                Console.WriteLine(i);
            }
            
            // this will return a bool
            
            Console.WriteLine(lc.Contains(100));  
            
            
        LinkedList<String> my_list = new LinkedList<String>(); 
  
        // Adding elements in the LinkedList 
        // Using AddLast() method 
        my_list.AddLast("Zoya"); 
        my_list.AddLast("Shilpa"); 
        my_list.AddLast("Rohit"); 
        my_list.AddLast("Rohan"); 
        my_list.AddLast("Juhi"); 
        my_list.AddLast("Zoya"); 
  
        // Inital number of elements 
        Console.WriteLine("Best students of XYZ "+ 
                         "university initially:"); 
  
        // Accessing the elements of  
        // Linkedlist Using foreach loop 
        foreach(string str in my_list) 
        { 
            Console.WriteLine(str); 
        } 
  
        // After using Remove(LinkedListNode) 
        // method 
        Console.WriteLine("Best students of XYZ"+ 
                         " university in 2000:"); 
  
        my_list.Remove(my_list.First); 
  
        foreach(string str in my_list) 
        { 
            Console.WriteLine(str); 
        } 
  
        // After using Remove(T) method 
        Console.WriteLine("Best students of XYZ"+ 
                         " university in 2001:"); 
  
        my_list.Remove("Rohit"); 
  
        foreach(string str in my_list) 
        { 
            Console.WriteLine(str); 
        } 
  
        // After using RemoveFirst() method 
        Console.WriteLine("Best students of XYZ"+ 
                         " university in 2002:"); 
  
        my_list.RemoveFirst(); 
  
        foreach(string str in my_list) 
        { 
            Console.WriteLine(str); 
        } 
  
        // After using RemoveLast() method 
        Console.WriteLine("Best students of XYZ"+ 
                         " university in 2003:"); 
  
        my_list.RemoveLast(); 
  
        foreach(string str in my_list) 
        { 
            Console.WriteLine(str); 
        } 
  
        // After using Clear() method 
        my_list.Clear(); 
        Console.WriteLine("Number of students: {0}", 
                                     my_list.Count); 
    } 
            
            
            
            
                      
            
        }
    }
