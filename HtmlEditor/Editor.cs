using System.Threading;
using System.IO;
using System.Text;
using System;

namespace HtmlEditor
{
    public static class Editor
    {

        public static void Show()
        {
            Console.Clear();
            Console.WriteLine("Editor");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            // Draw.DrawScreen(columns: 50, lines: 15);
            Start();

        }

        public static void Start()
        {
            var text = new StringBuilder();

            do
            {
                text.Append(Console.ReadLine());
                text.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Save(text);
            

        }

        public static void Save(StringBuilder text){
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Do you want save file? y/n");
            string option = Console.ReadLine().ToLower();
            
            switch (option)
            {
                case "y":
                    {
                        Console.WriteLine("Enter the path file");
                        string path = Console.ReadLine();
                        using (var file = new StreamWriter(path))
                        {
                            file.Write(text);
                        }
                    }
                    Console.WriteLine("Saved file with success");
                    Thread.Sleep(2000);
                    Menu.Show();
                    break;
                case "n":
                    {
                        Console.WriteLine("End of edit file");
                    }
                    Thread.Sleep(2000);
                    Show();
                    break;
                default:
                    Save(text);
                    break;
            }
        }

    }
}