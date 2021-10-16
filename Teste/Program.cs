using System;
using System.Globalization;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            // Em struct Pode-se instanciar um objeto sem parâmetro ou com parâmetro
            var product = new Product(id: 1, name: "Playstation 5", price: 500.00);

            var priceInReal = product.PriceInReal(5.45);
            Console.WriteLine(product);
            Console.WriteLine($"Price in Real: {priceInReal.ToString("C", CultureInfo.GetCultureInfo("pt-br"))}");
        }
    }
    struct Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"id: {Id} - Name: {Name} - Price in dollar: {Price.ToString("C")}";
        }

        public double PriceInReal(double dollar)
        {
            return Price * dollar * 1.65;
        }


    }
}
