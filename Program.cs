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
            Console.WriteLine("Введите первое число:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double x2 = double.Parse(Console.ReadLine());
            double sra = (x1 + x2) / 2;
            Console.WriteLine(sra);
            double srg = Math.Sqrt(x1 * x2);
            Console.WriteLine(srg);

            Console.ReadKey();
        }
    }
}
