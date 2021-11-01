using System;

namespace Labora01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            /*Console.WriteLine("Введите А");
            double a;
            a = double.Parse(Console.ReadLine());
            a = a * 10;
            int D = (int)a;
            D = D % 10;
            Console.WriteLine(D);

            //2

            Console.WriteLine("Введите кол-во секунд:");
            int s;
            s = int.Parse(Console.ReadLine());
            int h = s / 3600;
            int m = (s - (h * 3600)) / 60;
            Console.WriteLine("Прошло " + h + " часов и " + m + " минут");

            //3

            int h, m, s;
                Console.WriteLine("Введите кол-во часов");
                h = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во минут");
                m = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во секунд");
                s = int.Parse(Console.ReadLine());

                if (s > 60 | m > 60 | h > 12)
                {
                    Console.WriteLine("Неккоректные данные");
                }
                else
                {
                    double y, x;
                    x = h + m / 60 + s / 3600;
                    y = x / 12 * 360;
                    Console.WriteLine("Угол=" + y, " градусов");

            //4
                    Console.WriteLine("Ввод a");
                       int a = int.Parse(Console.ReadLine());
                       Console.WriteLine("Ввод b");
                       int b = int.Parse(Console.ReadLine());
                       a = a + b - (b = a);

           Console.WriteLine(a);
           Console.WriteLine(b);

            //5

            Console.WriteLine("Введите значения катетов");
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            double S = 0.5 * a * b;
            double c = Math.Sqrt(a * a + b * b);
            double p = a + b + c;
            Console.WriteLine("Площадь равна: " + S + " см^2 и периметр равен: " + p + "см");

            //6

            Console.WriteLine("Ввод чисел");
            char[] y = Console.ReadLine().ToCharArray();
            int n = 1;
            foreach (char x in y)
                n *= (int)x - 48;
            Console.WriteLine($"Равно: {n}");

            //7

            Console.WriteLine("Введите число: ");
            int a;
            a = int.Parse(Console.ReadLine());
            Console.Write("{0} -> ", a);
            int x = a % 10;
            while ((a /= 10) != 0) x = x * 10 + a % 10;
            Console.WriteLine("{0}", x);

            //8

           */ Console.WriteLine("Введите х:");
            int x, y;
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Упрoщение:");
            Console.WriteLine("(((3 * x - 5) * x + 2) * x - 1) * x + 7");
            y = (((3 * x - 5) * x + 2) * x - 1) * x + 7;
            Console.WriteLine("X = " + y +"");

            //9

            /*double a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3, x, y, z;
            Console.WriteLine("Заполните матрицу:");
            Console.WriteLine("a1 = ");
            a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("a2 = ");
            a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("a3 = ");
            a3 = double.Parse(Console.ReadLine());
            Console.WriteLine("b1 = ");
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("b2 = ");
            b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("b3 = ");
            b3 = double.Parse(Console.ReadLine());
            Console.WriteLine("c1 = ");
            c1 = double.Parse(Console.ReadLine());
            Console.WriteLine("c2 = ");
            c2 = double.Parse(Console.ReadLine());
            Console.WriteLine("c3 = ");
            c3 = double.Parse(Console.ReadLine());
            Console.WriteLine("d1 = ");
            d1 = double.Parse(Console.ReadLine());
            Console.WriteLine("d2 = ");
            d2 = double.Parse(Console.ReadLine());
            Console.WriteLine("d3 = ");
            d3 = double.Parse(Console.ReadLine());
            double del = a1 * b2 * c3 + b1 * c2 * a3 + c1 * a2 * b3 - c1 * b2 * a3 - b1 * a2 * c3 - a1 * c2 * b3;
            double del1 = d1 * b2 * c3 + b1 * c2 * d3 + c1 * d2 * b3 - c1 * b2 * d3 - b1 * d2 * c3 - d1 * c2 * b3;
            double del2 = a1 * d2 * c3 + d1 * c2 * a3 + c1 * a2 * d3 - c1 * d2 * a3 - d1 * a2 * c3 - a1 * c2 * d3;
            double del3 = a1 * b2 * d3 + b1 * d2 * a3 + d1 * a2 * b3 - d1 * b2 * a3 - b1 * a2 * d3 - a1 * d2 * b3;
            if (del != 0)
            {
                x = del1 / del;
                y = del2 / del;
                z = del3 / del;
                Console.WriteLine("x = {0}; y = {1}; z = {2}", x, y, z);
            }
            else Console.WriteLine("Error. Определитель ноль.");*/

        }
    }
    }
    

