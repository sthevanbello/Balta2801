using System.Globalization;
using System;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Money");
            Console.WriteLine("==================================\n");

            var valor = 10.25m;
            Console.WriteLine(valor.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));

            Console.ReadKey();
        }
    }
}
