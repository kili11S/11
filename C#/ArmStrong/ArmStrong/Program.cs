using System;

namespace ArmStrong
{
    class Program
    {
        static void Main(string[] args)
        {
        
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                // Простое или нет число
                int Dlin; double o; int n;
                string Hran;
                Console.Write("Введите число 1: ");
                int n1 = Convert.ToInt32(Console.ReadLine());

                if (n1 > 1 && n1 % 2 != 0 || n1 == 2)
                {
                    Console.WriteLine("Число простое");
                }
                else
                {
                    Console.WriteLine("Число НЕ простое");
                }


                // Число армстронга
                for (int j = 0; j <= n1; j++)
                {
                    Hran = Convert.ToString(j);
                    Dlin = Hran.Length;
                    char[] hranArr = Hran.ToCharArray();
                    o = 0;
                    for (int i = 1; i <= Dlin; i++)
                    {
                        n = hranArr[i - 1] - 48;
                        o += Math.Pow(n, Dlin);
                    }
                    if (j == o)
                    {
                        if (n1 == j)
                        {
                            Console.WriteLine("Число Армстронга");
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

            }
            
            // Исключения
            catch(FormatException)
            {
                Console.WriteLine("Введите ЧИСЛО");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Это слишком большое число. Мы его не потянем :(");
            }
        }
    }
}
