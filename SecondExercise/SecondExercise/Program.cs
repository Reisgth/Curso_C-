using System;
using System.Globalization;

namespace SecondExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdeRoom = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preco de um produto");
            double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha)");
            string[] words = Console.ReadLine().Split(' ');

            Console.WriteLine(fullName);
            Console.WriteLine(qtdeRoom);
            Console.WriteLine(prodPrice.ToString("F2", CultureInfo.InvariantCulture));

            string lastName;
            int age;
            double size;

            lastName = words[0];
            age = int.Parse(words[1]);
            size = double.Parse(words[2], CultureInfo.InvariantCulture);

            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(size.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
