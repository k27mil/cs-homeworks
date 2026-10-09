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
            Console.WriteLine("Введите трехзначное число:");
            string x = Console.ReadLine();
            string x2 = x[2] + x.Substring(0, 2);
            Console.WriteLine(x2);

            Console.ReadKey();
        }
    }
}
