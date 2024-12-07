using System;
using System.ComponentModel;
using System.Globalization;

namespace RepetitiveStructureFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 > 0)
            //        Console.WriteLine(i);
            //}

            //int number = int.Parse(Console.ReadLine());
            //int inside = 0, outside = 0;

            //for (int i = 0; i < number; i++)
            //{
            //    int value = int.Parse(Console.ReadLine());

            //    if (value < 10 || value > 20)
            //    {
            //        outside++;
            //    }
            //    else
            //    {
            //        inside++;
            //    }
            //}

            //Console.WriteLine($"{inside} in");
            //Console.WriteLine($"{outside} out");

            //int number = int.Parse(Console.ReadLine());
            //double val1, val2, val3, media;

            //for (int i = 0; i < number; i++)
            //{
            //    string[] values = Console.ReadLine().Split(" ");

            //    val1 = double.Parse(values[0], CultureInfo.InvariantCulture);
            //    val2 = double.Parse(values[1], CultureInfo.InvariantCulture);
            //    val3 = double.Parse(values[2], CultureInfo.InvariantCulture);

            //    media = (val1*2 + val2*3 + val3*5) / 10;

            //    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            //}

            //int number = int.Parse(Console.ReadLine());
            //int val1, val2;

            //for (int i = 0; i < number; i++)
            //{
            //    string[] values = Console.ReadLine().Split(" ");

            //    val1 = int.Parse(values[0]);
            //    val2 = int.Parse(values[1]);

            //    if(val2 == 0)
            //        Console.WriteLine("divisao impossivel");
            //    else
            //        Console.WriteLine((val1 / (val2*1.0)).ToString(CultureInfo.InvariantCulture));
            //}

            //int number = int.Parse(Console.ReadLine());
            //long fat = 1;

            //if (number == 0)
            //{
            //    Console.WriteLine(1);
            //}
            //else
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        fat *= i;
            //    }

            //    Console.WriteLine(fat);
            //}

            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    if ((number % i) == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
        }
    }
}