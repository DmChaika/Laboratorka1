using System;

namespace individual2
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, x, a, b, d;

            Console.WriteLine("Ваше значение x");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваше значение a");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ваше значение b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("1 формула");

            if (x != 0 && a != 0)
            {
                y = a * b * Math.Pow(x, 2) - (a / Math.Pow(Math.Sin(x / a), 2));
                Console.WriteLine("Ответ первой формулы:\ny = " + y);
            }
            else Console.WriteLine("Данные не входят в ОДЗ (x != 0 && a != 0)");

            Console.WriteLine("2 формула");

            if (a >= 0)
            {
                double e = 2.72;
                d = a * Math.Pow(e, -Math.Sqrt(a)) * Math.Cos((b * x) / a);
                Console.WriteLine("Ответ второй формулы:\nz = " + d);
            }
            else Console.WriteLine("Данные не входят в ОДЗ (a >= 0)");

        }
    }
}