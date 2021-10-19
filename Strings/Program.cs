using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guid");
            var id = Guid.NewGuid();
            Console.WriteLine(id);
            Console.ReadKey();
        }
    }
}
