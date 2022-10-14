using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treugolnik
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3, a, b, c, p, s, r, R, M1, M2, M3, L1, L2, L3, H1, H2, H3, ug1, ug2, ug3, u1, u2, u3, sina;
            Random random = new Random();

            x1 = 10 + random.NextDouble() * (100 - 10 + 1);
            x2 = 10 + random.NextDouble() * (100 - 10 + 1);
            x3 = 10 + random.NextDouble() * (100 - 10 + 1);
            y1 = 10 + random.NextDouble() * (100 - 10 + 1);
            y2 = 10 + random.NextDouble() * (100 - 10 + 1);
            y3 = 10 + random.NextDouble() * (100 - 10 + 1); 

            //Console.Write("Введите x1: ");
            //x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите y1: ");
            //y1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите x2: ");                     //////////////////////////////////////////////////
            //x2 = Convert.ToDouble(Console.ReadLine());         //Пользователь вносит вводные данные в программу//
            //Console.Write("Введите y2: ");                     //////////////////////////////////////////////////
            //y2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите x3: ");
            //x3 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите y3: ");
            //y3 = Convert.ToDouble(Console.ReadLine());

            a = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));     //Вычисление стороны a
            Console.Write("Значение A: " + a + '\n');

            b = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));     //Вычисление стороны b
            Console.Write("Значение B: " + b + '\n');

            c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));     //Вычисление стороны c
            Console.Write("Значение C: " + c + '\n');

            p = (a + b + c) / 2;                                            //Периметр 1/2

            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));                 //Вычисление площади
            Console.Write("Площадь: " + s + '\n');

            r = Math.Sqrt((p - a) * (p - b) * (p - c)) / p;                 // Радиус ВП
            Console.Write("Радиус вписанной окружности: " + r + "\n");

            R = (a * b * c) / 4 * Math.Sqrt(p * (p - a) * (p - b) * (p - c)); //Радиус ОО
            Console.Write("Радиус описанной окружности: " + R + "\n");

            M1 = (Math.Sqrt((2 * Math.Pow(a, 2)) + (2 * Math.Pow(b, 2)) - Math.Pow(c, 2))) / 2; //Медиана C
            Console.Write("Длина медиан треугольника к стороне С: " + M1 + "\n");

            M2 = (Math.Sqrt(2 * Math.Pow(a, 2) + 2 * Math.Pow(c, 2) - Math.Pow(b, 2)));         //Медиана B
            Console.Write("Длина медиан треугольника к стороне B: " + M2 + "\n");

            M3 = (Math.Sqrt(2 * Math.Pow(b, 2) + 2 * Math.Pow(c, 2) - Math.Pow(a, 2)));          //Медиана A
            Console.Write("Длина медиан треугольника к стороне A: " + M3 + "\n");

            L1 = (2 * (Math.Sqrt(a * b * p * (p - c)))) / (a + b);                              //Биссектриса С
            Console.Write("Длина биссектрисы к стороне С: " + L1 + "\n");

            L2 = (2 * Math.Sqrt(b * c * p * (p - a))) / b + c;                      //Биссектриса2
            Console.Write("Длина биссектриссы 2: " + L2 + "\n");

            L3 = (2 * Math.Sqrt(a * c * p * (p - b))) / a + c;                      //Биссекртиса3
            Console.Write("Длина биссектриссы 3: " + L3 + "\n");

            sina = Math.Sin(a);
            Console.Write("Длина биссектриссы 3: " + sina + "\n");
           
            ug1 = Math.Asin(a / (2 * R));
            Console.Write("Угол А в радианах: " + ug1 + "\n");

            ug2 = Math.Asin(b / (2 * R));
            Console.Write("Угол B в радианах: " + ug2 + "\n");

            ug3 =  Math.Asin(c / (2 * R));
            Console.Write("Угол C в радианах: " + ug3 + "\n");

            u1 = ug1 * (100.0 / Math.PI);
            u2 = ug2 * (100.0 / Math.PI);
            u3 = ug3 * (100.0 / Math.PI);

            Console.WriteLine("Угол А в градусах {0}", u1);
            Console.WriteLine("Угол B в градусах {0}", u2);
            Console.WriteLine("Угол С в градусах {0}", u3);

            H1 = ug2;
            H2 = ug3;
            H3 = ug1;
            Console.WriteLine("Высота А равна: {0}", H1);
            Console.WriteLine("Высота B равна: {0}", H2);
            Console.WriteLine("Высота C равна: {0}", H3);

            Console.ReadKey();                                                      // УГЛЫ В ГР. И РД. МЕРЕ И ДЛИНЫ ВЫСОТ
        }
    }
}
