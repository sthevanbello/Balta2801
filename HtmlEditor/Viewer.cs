using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace HtmlEditor
{
    public static class Viewer
    {


        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("----------------------------------------");
            Replace(text);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');
            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))
                        )
                    );
                    Console.Write(" ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
        }

        public static void Open(){
            Console.SetCursorPosition(3, 13);
            Console.Write("Enter the path file: ");
            Console.SetCursorPosition(24, 13);
            string path = Console.ReadLine();
            var text = new StringBuilder();
            
            using(var file = File.OpenText(path)){

                while(!file.EndOfStream){
                    text.AppendLine(file.ReadLine());
                }
            }
            Show(text.ToString());
        }
    }

}