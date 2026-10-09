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
            Console.WriteLine("Введите величину a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите величину b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите величину c");
            int c = int.Parse(Console.ReadLine());
            int x = a;
            int y = b;
            int z = c;
            b = z; a = y; c = x;
            Console.WriteLine($"a:{a} b:{b} c:{c}");
            b = x; c = y; a = z;
            Console.WriteLine($"a:{a} b:{b} c:{c}");


            Console.ReadKey();
        }
    }
}
