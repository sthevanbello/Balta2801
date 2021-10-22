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
            DrawScreen();
            WriteOptions();
            Console.ReadKey();
        }

        public static void DrawScreen()
        {
            Columns(50);
            Body(lines: 20, columns: 50);
            Columns(50);
        }

        private static void Body(int lines, int columns)
        {
            for (int i = 0; i <= lines; i++)
            {
                Console.Write("|");
                for (int j = 0; j <= columns; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }
        }

        private static void Columns(int columns)
        {
            Console.Write("+");
            for (int i = 0; i <= columns; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
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
            Console.WriteLine("3 - Exit");
            Console.SetCursorPosition(3, 9);
            Console.Write("Option: ");

        }
    }
}
