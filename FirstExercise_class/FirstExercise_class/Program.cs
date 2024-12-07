using FirstExercise_class;
using System;
using System.Globalization;

namespace firstExercise_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa");
            pessoa.name = Console.ReadLine();
            pessoa.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da Segunda pessoa");
            pessoa2.name = Console.ReadLine();
            pessoa2.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa");
            Console.WriteLine("Nome: " + pessoa.name);
            Console.WriteLine("Idade: " + pessoa.age);

            Console.WriteLine("Dados da primeira pessoa");
            Console.WriteLine("Nome: " + pessoa2.name);
            Console.WriteLine("Idade: " + pessoa2.age);

            if(pessoa.age > pessoa2.age)
                Console.WriteLine("Pessoa mais velha: " + pessoa.name);
            else
                Console.WriteLine("Pessoa mais velha: " + pessoa2.name);


            Funcionario funcionario = new Funcionario();
            Funcionario funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario");
            funcionario.name = Console.ReadLine();
            funcionario.money = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo funcionario");
            funcionario2.name = Console.ReadLine();
            funcionario2.money = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funcionario");
            Console.WriteLine("Nome: " + funcionario.name);
            Console.WriteLine("Idade: " + funcionario.money);

            Console.WriteLine("Dados do segundo funcionario");
            Console.WriteLine("Nome: " + funcionario2.name);
            Console.WriteLine("Idade: " + funcionario2.money);

            Console.WriteLine("Salario Medio = " + (funcionario.money+funcionario2.money)/2);
        }
    }
}