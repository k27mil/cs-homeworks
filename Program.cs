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
            Console.WriteLine("Введите число >999");
            int x = int.Parse(Console.ReadLine());
            int hundreds = x / 100;
            int thousands = x / 1000;
            Console.WriteLine($"сотен {hundreds} тысяч {thousands}");

            Console.ReadKey();
        }
    }
}
