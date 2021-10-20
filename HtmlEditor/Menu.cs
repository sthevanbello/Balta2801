using System;

namespace HtmlEditor
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("HTML Editor");
            Console.BackgroundColor = ConsoleColor.Black;
            DrawScreen();
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
    }
}
