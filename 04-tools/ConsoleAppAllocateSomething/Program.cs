using System;

using System.Linq;

namespace ConsoleAppAllocateSomething
{
    class MyType
    {
        public Guid Guid = Guid.NewGuid();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            var myTypes = new MyType[1_000_000];
            for (var x = 0; x < 1_000_000; x++)
            {
                myTypes[x] = new MyType();
            }
            Console.WriteLine(myTypes.Count());
            Console.ReadKey();
        }
    }
}
