using System.Threading;
using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Choose a option");
            Console.WriteLine("1 - Open file");
            Console.WriteLine("2 - Create a new file");
            Console.WriteLine("3 - Exit");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Open();
                    break;
                case 2:
                    Edit();
                    break;
                case 3:
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Open()
        {
            Console.Clear();
            Console.Write("Enter the path file: ");
            string path = Console.ReadLine();

            // using (var file = File.OpenText(path))
            // {
            //     while(!file.EndOfStream){
            //         Console.WriteLine(file.ReadLine());
            //     }
            // }
            using(var file = new StreamReader(path)){
                Console.WriteLine(file.ReadToEnd());
            }
            Console.ReadKey();
            Menu();
        }

        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Input a text (ESC to exit)");
            Console.WriteLine("------------------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
                // text += "\n";

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.Write("Enter the path to save a file: ");
            string path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            };
            Console.WriteLine("Saved file with success");
            Thread.Sleep(2000);
            Menu();
        }
    }


}
