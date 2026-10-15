using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_homeworks
{
    internal class Program
    {
        static int finobacci(int k)
        {
            if (k == 1 || k == 2) return 1;
            return finobacci(k - 1) + finobacci(k - 2);
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(finobacci(4));
        }
    }
}
