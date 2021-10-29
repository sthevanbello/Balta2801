using System.Runtime.CompilerServices;
using System;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // var data = DateTime.Now;

            var data = new DateTime(2021, 10, 26);
            
            Console.WriteLine(data.ToString("dd - MM - yyyy"));
            Console.WriteLine(data.DayOfWeek);

            var dataHoje = DateTime.Now;
            var formatada = String.Format("{0:dd-MM-yyyy - ff zzz}", dataHoje);
            Console.WriteLine(formatada);
            var formatada2 = String.Format("{0:G}", dataHoje);
            var formatada3 = String.Format("{0:r}", dataHoje);
            var formatada4 = String.Format("{0:s}", dataHoje);
            var formatada5 = String.Format("{0:u}", dataHoje);
            Console.WriteLine(formatada2);
            Console.WriteLine(formatada3);
            Console.WriteLine(formatada4);
            Console.WriteLine(formatada5);

            var dataAdd = DateTime.Now;
            var newData = dataAdd.AddDays(30);
            Console.WriteLine(newData);

            dataAdd = DateTime.Now;
            newData = dataAdd.AddMonths(6);
            Console.WriteLine(newData);

            dataAdd = DateTime.Now;
            newData = dataAdd.AddYears(6);
            Console.WriteLine(newData);
            
            newData = dataAdd.AddYears(-2);
            Console.WriteLine(newData);


            Console.ReadKey();
        }
    }
}
