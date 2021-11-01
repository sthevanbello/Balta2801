using System.Runtime.CompilerServices;
using System;
using System.Globalization;

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
            // var formatada = String.Format("{0:dd-MM-yyyy - ff zzz}", dataHoje);
            // Console.WriteLine(formatada);
            // var formatada2 = String.Format("{0:G}", dataHoje);
            // var formatada3 = String.Format("{0:r}", dataHoje);
            // var formatada4 = String.Format("{0:s}", dataHoje);
            // var formatada5 = String.Format("{0:u}", dataHoje);
            // Console.WriteLine(formatada2);
            // Console.WriteLine(formatada3);
            // Console.WriteLine(formatada4);
            // Console.WriteLine(formatada5);

            // var dataAdd = DateTime.Now;
            // var newData = dataAdd.AddDays(30);
            // Console.WriteLine(newData);

            // dataAdd = DateTime.Now;
            // newData = dataAdd.AddMonths(6);
            // Console.WriteLine(newData);

            // dataAdd = DateTime.Now;
            // newData = dataAdd.AddYears(6);
            // Console.WriteLine(newData);

            // newData = dataAdd.AddYears(-2);
            // Console.WriteLine(newData);

            // Console.WriteLine("\n================================\n");

            // var ptBr = new CultureInfo("pt-BR");
            // var ptPt = new CultureInfo("pt-PT");
            // var en = new CultureInfo("en-US");
            // var de = new CultureInfo("de-DE");

            // Console.WriteLine(DateTime.Now.ToString("D", ptBr));
            // Console.WriteLine(DateTime.Now.ToString("D", ptPt));
            // Console.WriteLine(DateTime.Now.ToString("D", en));
            // Console.WriteLine(DateTime.Now.ToString("D", de));

            // Console.WriteLine("\n================================\n");
            // var dataUtc = DateTime.UtcNow;

            // Console.WriteLine(dataUtc);

            // Console.WriteLine(dataUtc.ToLocalTime());

            // Console.WriteLine("\n================================\n");
            // var timezones = TimeZoneInfo.GetSystemTimeZones();
            // foreach (var timezone in timezones)
            // {
            //     Console.WriteLine(timezone.Id);
            //     Console.WriteLine(timezone);
            //     Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dataUtc, timezone));
            //     Console.WriteLine("_________");
            // }

            var timeSpan = new TimeSpan(1);
            Console.WriteLine(timeSpan);
            var timeSpan2 = new TimeSpan(1, 15, 25);
            Console.WriteLine(timeSpan2);
            var timeSpanDiaHora = new TimeSpan(25,1, 15, 25);
            Console.WriteLine(timeSpanDiaHora);
            Console.WriteLine(timeSpanDiaHora.Days);
            Console.WriteLine(timeSpanDiaHora.Add(new TimeSpan(12, 0, 0)));

            Console.WriteLine($"Today ({DateTime.Now.DayOfWeek}) is weekend? {IsWeekend(DateTime.Now.DayOfWeek)}");

            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

            static bool IsWeekend(DayOfWeek today){
                return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
            }


            Console.ReadKey();
        }
    }
}
