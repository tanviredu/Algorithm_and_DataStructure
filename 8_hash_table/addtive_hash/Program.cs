using System;

namespace addtive_hash
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Tanvir Rahman";
            
            int hash = Addtive_hash.run(name);
            Console.WriteLine(hash);
        }
        
        
    }
}
