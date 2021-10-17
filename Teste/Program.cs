using System;
using System.Globalization;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            // Em struct pode-se instanciar um objeto sem parâmetro ou com parâmetro independentemente do construtor. 
            // Assumindo os valores padrões do tipo (int = 0, bool = true, string = "" e os demais)
            // Em class não se pode instanciar sem parâmetros no construtor se forem obrigatórios pelo construtor da classe

            var product = new Product(id: 1, name: "Playstation 5", price: 500.00);
            // var product = new Product();

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
