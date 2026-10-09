using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace cs_homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string m = Console.ReadLine();
            Console.WriteLine("Как тебя зовут?");
            string a = Console.ReadLine();
            Console.WriteLine($"Привет {a}");
            string b = Console.ReadLine();
            Console.WriteLine("Да");
            string c = Console.ReadLine();
            Console.WriteLine("Нет");

            Thread.Sleep(5000);
            Random rnd = new Random();
            int x = rnd.Next(1, 16);
            Console.ForegroundColor = (ConsoleColor)x;
            Console.WriteLine("Но могу показать");

            Console.ReadKey();
        }
    }
}
