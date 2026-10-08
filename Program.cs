using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cs_homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double radians = x * (Math.PI / 180);
            Console.WriteLine(Math.Cos(radians));

            Console.ReadKey();
        }
    }
}
