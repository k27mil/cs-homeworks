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
            Console.WriteLine("Введите большее основание трапеции:");
            int osn1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите меньшее основание трапеции:");
            int osn2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту трапеции:");
            int h = int.Parse(Console.ReadLine());
            int x = (osn1 - osn2) / 2;
            int kvstorona = x * x + h * h;
            double storona = Math.Sqrt(kvstorona);
            double perimetr = storona * 2 + osn1 + osn2;
            Console.WriteLine($"Периметр трапеции равен: {perimetr}");

            Console.ReadKey();
        }
    }
}
