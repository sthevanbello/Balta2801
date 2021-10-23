using System;

namespace HtmlEditor{
    public static class Draw{
        public static void DrawScreen(int columns, int lines)
        {
            Columns(columns: columns);
            Body(lines: lines, columns: columns);
            Columns(columns: columns);
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