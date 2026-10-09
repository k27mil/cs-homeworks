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
            Console.WriteLine("Введите количество секунд:");
            int x = int.Parse(Console.ReadLine());
            int hours = x / 3600;
            int minutes = (x % 3600) / 60;
            int seconds = (x % 3600) % 60;
            Console.WriteLine($"{hours}, {minutes}, {seconds}");


            Console.ReadKey();
        }
    }
}
