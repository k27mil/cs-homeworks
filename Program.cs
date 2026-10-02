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
            Console.WriteLine("Введите коэффицент a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффицент b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффицент c");
            int c = int.Parse(Console.ReadLine());
            int D = b * b - 4 * a * c;
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine("корень x1:" + x1);
            Console.WriteLine("корень x2:" + x2);


            Console.ReadKey();

        }
    }
}
