using System;

namespace djb2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "tanvir Rahman";
            int hash = Djb2.run(name);
            Console.WriteLine(hash);
        }
    }
}
