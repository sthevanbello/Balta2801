using System.Linq;
using System.Threading;
using System;
namespace Cronometer
{
    class Program
    {
        enum EType
        {
            second = 1,
            minute = 2

        }
        static void Main(string[] args)
        {
            Menu();
        }
        private static void Menu()
        {
            // Console.Clear();
            Console.WriteLine("how long time do you want to count?");
            Console.WriteLine("s = Seconds => 10s = 10 seconds");
            Console.WriteLine("m = Minutes => 1m = 1 minute");
            Console.WriteLine("0 = Exit");
            Console.WriteLine("Choose a option");

            string item = Console.ReadLine().ToLower();

            string type = item.Substring(item.Length - 1);
            string time = item.Substring(0, item.Length - 1);

            switch (type)
            {
                case "s":
                    Start(int.Parse(time), EType.second);
                    break;
                case "m":
                    Start(int.Parse(time), EType.minute);
                    break;
                case "0":
                    Console.WriteLine("End of program")
                    break;
                default:
                    Menu();
                    break;
            }
        }
        private static void Start(int time, EType type)
        {
            if (type == EType.minute)
            {
                Minute(time);
            }
            else
            {
                Second(time);
            }
            Menu();
        }

        private static void Second(int time)
        {
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine($"{currentTime}");
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronometer finished");
            Thread.Sleep(2000);
        }

        private static void Minute(int time)
        {
            int currentTime = 0;
            time *= 60;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronometer finished");
            Thread.Sleep(2000);
        }
    }
}
