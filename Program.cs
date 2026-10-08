using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты первой точки по х:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты первой точки по y:");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки по х:");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты второй точки по y:");
            int y2 = int.Parse(Console.ReadLine());
            int x;
            int y;
            if (x1 > x2)
            {
                x = x1 - x2;
            }
            else
            {
                x = x2 - x1;
            }
            if (y1 > y2)
            {
                y = y1 - y2;
            }
            else
            {
                y = y2 - y1;
            }
            int kvdrt = x * x + y * y;
            Console.WriteLine(Math.Sqrt(kvdrt));

            Console.ReadKey();
        }
    }
}
