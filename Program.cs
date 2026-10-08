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
            Random rnd = new Random();
            int n1 = rnd.Next(1, 100);
            int n2 = rnd.Next(1, 100);
            int n3 = rnd.Next(1, 100);
            int n4 = rnd.Next(1, 100);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            Console.ReadKey();
        }
    }
}
