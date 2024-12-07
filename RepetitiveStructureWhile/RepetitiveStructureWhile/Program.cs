using System;
using System.Globalization;

namespace RepetitiveStructureWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int password = int.Parse(Console.ReadLine());

            //while (password != 2002)
            //{
            //    Console.WriteLine("Senha invalida");
            //    password = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Acesso Permitido");

            //string[] coord = Console.ReadLine().Split(" ");

            //int cord1 = int.Parse(coord[0]);
            //int cord2 = int.Parse(coord[1]);

            //while (cord1 != 0 && cord2 != 0)
            //{
            //    if (cord1 > 0 && cord2 > 0)
            //    {
            //        Console.WriteLine("primeiro");
            //    }
            //    else if (cord1 < 0 && cord2 < 0)
            //    {
            //        Console.WriteLine("terceiro");
            //    }
            //    else if (cord1 < 0 && cord2 > 0)
            //    {
            //        Console.WriteLine("segundo");
            //    }
            //    else if(cord1 > 0 && cord2 < 0)
            //    {
            //        Console.WriteLine("quarto");
            //    }

            //    coord = Console.ReadLine().Split(" ");

            //    cord1 = int.Parse(coord[0]);
            //    cord2 = int.Parse(coord[1]);
            //}

            int gas = int.Parse(Console.ReadLine());

            int a = 0, g = 0, d = 0;

            while (gas != 4)
            {
                switch (gas)
                {
                    case 1:
                        {
                            a++;
                            break;
                        }
                    case 2:
                        {
                            g++;
                            break;
                        }
                    case 3:
                        {
                            d++;
                            break;
                        }
                    default:
                        break;
                }

                gas = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {a}");
            Console.WriteLine($"Gasolina: {g}");
            Console.WriteLine($"Diesel: {d}");
        }
    }
}