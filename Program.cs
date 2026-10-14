using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_homeworks
{
    internal class Program
    {
        static void swap(ref int a, ref int b)
        {
            int x = a;
            a = b;
            b = x;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            swap(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
