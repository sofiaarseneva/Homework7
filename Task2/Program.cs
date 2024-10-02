using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void GetKubeVandS (double a, out double s, out double v)
        {
            v = Math.Pow(a, 3);
            s = 6 * Math.Pow(a, 2);
        }

        static void Main(string[] args)
        {
            //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
            Console.WriteLine("Введите длину ребра куба: ");
            double a = Convert.ToDouble(Console.ReadLine());
            double v, s;
            if (a == 0 || a < 0)
            {
                Console.WriteLine("Введено некорректное значение ребра куба!");
            }
            else
            {
                GetKubeVandS(a, out s, out v);
                Console.WriteLine("Объем куба равен {0:.00}, площадь поверхности куба равна {1:.00}!", v, s);
            }
            Console.ReadKey();
        }
    }
}
