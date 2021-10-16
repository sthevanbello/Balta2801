using System;
using System.Globalization;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 100;

            Console.WriteLine(inteiro);

            float real = 25.5f;

            Console.WriteLine(real);
            //inteiro = real;
            real = inteiro;
            Console.WriteLine(real);

            real = 25.5f;
            inteiro = (int)real;
            Console.WriteLine(inteiro);

            inteiro = Convert.ToInt32(real);
            Console.WriteLine(inteiro);
        }
    }
}
