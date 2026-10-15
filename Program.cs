using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_homeworks
{
    internal class Program
    {
        static int Factorial(int x)
        {
            if (x <= 1)
            {
                return 1;
            }
            return x * Factorial(x - 1);
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(x));
        }
    }
}
