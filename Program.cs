using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cs_homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Ваш город:");
            string city = Console.ReadLine();
            Console.WriteLine("Ваш возраст:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Ваш код");
            int password = int.Parse(Console.ReadLine());

            Console.WriteLine($"{name}, {age}, {city}, {password}");

            Console.ReadKey();
        }
    }
}
