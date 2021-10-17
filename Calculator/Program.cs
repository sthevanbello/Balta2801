using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator();

        }

        private static void Calculator()
        {
            Console.Clear();
            Menu();
            Console.ReadKey();
        }

        private static void Menu()
        {
            int item = 0;
            float[] value;

            while (item != 5)
            {
                Console.WriteLine("Choose a math operation");
                Console.WriteLine("1 - Sum");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Division");
                Console.WriteLine("4 - Multiplication");
                Console.WriteLine("5 - Exit");

                item = int.Parse(Console.ReadLine());
                switch (item)
                {
                    case 1:
                        value = ReadValues();
                        Sum(value);
                        break;
                    case 2:
                        value = ReadValues();
                        Subtract(value);
                        break;
                    case 3:
                        value = ReadValues();
                        Division(value);
                        break;
                    case 4:
                        value = ReadValues();
                        Multiplication(value);
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("\nInvalid operation\n");
                        break;
                }
            }


            Console.WriteLine("\nEnd of program");
        }
        private static float[] ReadValues()
        {
            Console.Clear();
            float[] value = new float[2];

            Console.Write("First value: ");
            value[0] = float.Parse(Console.ReadLine());

            Console.Write("Second value: ");
            value[1] = float.Parse(Console.ReadLine());

            return value;
        }
        private static void Sum(float[] value)
        {
            float result = value[0] + value[1];
            Console.WriteLine();
            Console.WriteLine("Sum");
            Console.WriteLine($"{value[0]} + {value[1]} = {result}\n");
        }

        private static void Subtract(float[] value)
        {
            float result = value[0] - value[1];
            Console.WriteLine();
            Console.WriteLine("Subtract");
            Console.WriteLine($"{value[0]} - {value[1]} = {result}\n");
        }

        private static void Division(float[] value)
        {

            float result = value[0] / value[1];
            Console.WriteLine();
            Console.WriteLine("Division");
            Console.WriteLine($"{value[0]} / {value[1]} = {result}\n");
        }

        private static void Multiplication(float[] value)
        {
            float result = value[0] * value[1];
            Console.WriteLine();
            Console.WriteLine("Multiplication");
            Console.WriteLine($"{value[0]} x {value[1]} = {result}\n");
        }
    }
}
