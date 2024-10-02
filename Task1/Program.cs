using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static double GetTriangleS (double x, double y, double z)
        {
            //проверяем, существует ли треугольник, если да, считаем площадь
            //треугольник сущ. тогда и только тогда, когда сумма любых двух сторон больше третьей
            if (x + y > z & x + z > y & y + z > x)
            {
                //полупериметр
                double p = (x + y + z) / 2.0;
                //площадь по формуле Герона
                return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            }
            else //если не существует, вызвращаем -1
            {
                return -1;
            }
        }

        static void Main(string[] args)
        {
            //Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше
            //(создать метод для вычисления  площади  треугольника по длинам его сторон).
            //Для решения задачи можно использовать формулу Герона
            double s1, s2;
            
            Console.WriteLine("Введите сторону x первого треугольника:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону y первого треугольника:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону z первого треугольника:");
            double z1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите сторону x второго треугольника:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону y второго треугольника:");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону z второго треугольника:");
            double z2 = Convert.ToDouble(Console.ReadLine());
            
            s1 = GetTriangleS(x1, y1, z1);
            s2 = GetTriangleS(x2, y2, z2);

            if (s1 == -1 || s2 == -1)
            {
                Console.WriteLine("Один из треугольников не существует!");
                
            } else
            {
                Console.WriteLine("Площадь первого треугольника по формуле Герона равна {0:.00}", s1);
                Console.WriteLine("Площадь второго треугольника по формуле Герона равна {0:.00}", s2);

                if (s1 > s2)
                {
                    Console.WriteLine("Площадь первого треугольника больше площади второго!");
                }
                else if (s1 < s2)
                {
                    Console.WriteLine("Площадь второго треугольника больше площади первого!");
                }
                else
                {
                    Console.WriteLine("Площади равны!");
                }
            }

            Console.ReadKey();
        }
    }
}
