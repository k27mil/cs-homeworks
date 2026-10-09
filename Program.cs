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
            Console.WriteLine("Введите ваше имя");
            string x = Console.ReadLine();
            Console.WriteLine(x);
            Console.WriteLine($"Привет, {x}!");

            Console.ReadKey();
        }
    }
}
