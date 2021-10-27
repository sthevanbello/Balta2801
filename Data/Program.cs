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

            Console.ReadKey();
        }
    }
}
