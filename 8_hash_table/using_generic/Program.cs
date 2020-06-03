using System;
using System.Collections;
namespace using_generic
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable _hash = new Hashtable();
            _hash.Add("1","tanvir");
            _hash.Add("2","Rahman");
            _hash.Add("3","This is vscode");
            
            
            // must say the type 
            // cant use var in this poing
            foreach(DictionaryEntry item in _hash){
                Console.WriteLine($" {item.Key}  and {item.Value} ");
            }
        }
    }
}
