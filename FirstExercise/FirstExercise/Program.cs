using System;
using System.Globalization;

namespace FirstExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prod1, prod2;

            int age, code;

            char gender;

            double price1, price2, measure;

            prod1 = "Computador";
            prod2 = "Mesa de escritório";

            age = 30;
            code = 5290;

            gender = 'M';

            price1 = 2100.0;
            price2 = 650.50;
            measure = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{prod1}, cujo preco eh {price1}");
            Console.WriteLine($"{prod2}, cujo preco eh {price2}");

            Console.WriteLine($"Registro: {age} de idade, codigo {code} e genero {gender}");

            Console.WriteLine($"Medida com 8 casas decimais: {measure:F8}");
            Console.WriteLine($"Arredondando (3 casas decimais): {measure:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {measure.ToString(CultureInfo.InvariantCulture)}");
        }
    }
}