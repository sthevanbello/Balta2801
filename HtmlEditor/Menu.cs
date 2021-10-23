using System;

namespace HtmlEditor
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Draw.DrawScreen(columns: 30, lines: 10);
            WriteOptions();
            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
            
            Console.ReadKey();
        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("HTML Editor");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("=======================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Choose a option");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("-----------------------");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Create a new file");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Open file");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("-----------------------");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("3 - Exit");
            Console.SetCursorPosition(3, 10);
            Console.Write("Option: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1:
                    {
                        Editor.Show();
                    }
                    break;
                case 2:
                    {

                    }
                    break;
                case 3:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                    }
                    break;
                default:
                    Show();
                    break;
            }
        }
    }
}
