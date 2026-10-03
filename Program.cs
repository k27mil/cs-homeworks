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
            Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
            Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
            Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
            Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");

            Console.ReadKey();
        }
    }
}
