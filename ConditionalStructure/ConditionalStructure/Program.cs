using System;
using System.Globalization;

namespace ConditionalStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());

            //if (num < 0)
            //{
            //    Console.WriteLine("NEGATIVO");
            //}
            //else
            //{
            //    Console.WriteLine("NAO NEGATIVO");
            //}

            //string[] input = Console.ReadLine().Split(" ") ;

            //int num1 = int.Parse(input[0]);
            //int num2 = int.Parse(input[1]);

            //if (num1 > num2)
            //{
            //    if (num1 % num2 == 0)
            //    {
            //        Console.WriteLine("Sao Multiplos");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nao sao Multiplos");
            //    }
            //}
            //else
            //{
            //    if (num2 % num1 == 0)
            //    {
            //        Console.WriteLine("Sao Multiplos");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Nao sao Multiplos");
            //    }
            //}

            //string[] input = Console.ReadLine().Split(" ");

            //int initHour = int.Parse(input[0]);
            //int FinalHour = int.Parse(input[1]);

            //if (initHour < FinalHour)
            //{
            //    Console.WriteLine($"O JOGO DUROU {FinalHour - initHour} HORA(S)");
            //}
            //else if (initHour == FinalHour)
            //{
            //    Console.WriteLine("O JOGO DUROU 24 HORA(S)");
            //}
            //else
            //{
            //    Console.WriteLine($"O JOGO DUROU {(24-initHour) + FinalHour} HORA(S)");
            //}

            //string[] input = Console.ReadLine().Split(" ");

            //int itemCode = int.Parse(input[0]);
            //int itemQtd = int.Parse(input[1]);

            //switch (itemCode)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine($"Total: R$ {itemQtd * 4.00}");
            //            break;

            //        }
            //    case 2:
            //        {
            //            Console.WriteLine($"Total: R$ {itemQtd * 4.50}");
            //            break;

            //        }
            //    case 3:
            //        {
            //            Console.WriteLine($"Total: R$ {itemQtd * 5.00}");
            //            break;

            //        }
            //    case 4:
            //        {
            //            Console.WriteLine($"Total: R$ {itemQtd * 2.00}");
            //            break;

            //        }
            //    case 5:
            //        {
            //            Console.WriteLine($"Total: R$ {itemQtd * 1.50}");
            //            break;

            //        }
            //}

            double isInInterval = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (isInInterval < 0 || isInInterval > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (isInInterval <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (isInInterval <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (isInInterval <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (isInInterval <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}