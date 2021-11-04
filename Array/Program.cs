using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Working with Array");
            var meuArray = new int[2]{2, 6};

            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);

            foreach (var item in meuArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
