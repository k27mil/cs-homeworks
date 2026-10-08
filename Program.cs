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
            Console.WriteLine("Введите переменную 1:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную 2:");
            int x2 = int.Parse(Console.ReadLine());
            int a = x1;
            x1 = x2;
            x2 = a;
            Console.WriteLine($"Переменная 1: {x1} Переменная 2: {x2}");

            Console.ReadKey();
        }
    }
}
