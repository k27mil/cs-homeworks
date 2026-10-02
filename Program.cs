using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_homeworks
{
    enum bank
    {
        Current,
        Savings
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank x = bank.Current;
            Console.WriteLine($"Счет {x}");
            
            Console.ReadKey();
        }
    }
}
