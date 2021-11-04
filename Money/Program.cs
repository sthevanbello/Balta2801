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

            var valor = 10.57m;
            decimal valorDecimal = 10.25m;

            Console.WriteLine(valor.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
            Console.WriteLine(valorDecimal.ToString("C", CultureInfo.GetCultureInfo("pt-BR")));
            Console.WriteLine(valorDecimal.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine(valorDecimal.ToString("C", CultureInfo.CreateSpecificCulture("de-DE")));

            Console.WriteLine(Math.Ceiling(valor));
            Console.WriteLine(Math.Floor(valor));
            Console.WriteLine(Math.Round(valor));
            Console.WriteLine(Math.Abs(valor));

            Console.ReadKey();
        }
    }
}
