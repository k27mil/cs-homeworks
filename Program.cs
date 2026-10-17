using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_homeworks
{
    internal class Program
    {
        static int NOD(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
            
        }
        static int NOD(int a, int b, int c)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);
            return NOD(NOD(a, b), c);
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(NOD(a, b, c));
        }
    }
}
