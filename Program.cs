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
            int x = 543;
            int y = 130;
            int k1 = 0; int k2 = 0;
            while (x >= 130)
            {
                k1++;
                x = x - 130;
            }
            while (y >= 130)
            {
                k2++;
                y = y - 130;
            }
            int kvadratiki = k1 * k2;
            Console.WriteLine(kvadratiki);

            Console.ReadKey();
        }
    }
}
