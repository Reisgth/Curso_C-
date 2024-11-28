using System;

namespace evenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite um numero inteiro: ");
            //int value = int.Parse(Console.ReadLine());

            //if (value % 2 == 0)
            //{
            //    Console.WriteLine("Eh par");
            //}
            //else
            //{
            //    Console.WriteLine("Eh impar");
            //}

            Console.WriteLine("Qual a hora atual?");
            int hour = int.Parse(Console.ReadLine());

            if (hour < 12)
            { 
                Console.WriteLine("Bom dia");
            }
            else if (hour < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }
        }
    }
}