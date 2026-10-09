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
            int n1 = rnd.Next(1, 10);
            int n2 = rnd.Next(1, 10);
            int n3 = rnd.Next(1, 10);
            int n4 = rnd.Next(1, 10);
            int n5 = rnd.Next(1, 10);
            int n6 = rnd.Next(1, 10);
            int n7 = rnd.Next(1, 10);
            int n8 = rnd.Next(1, 10);
            int n9 = rnd.Next(1, 10);
            int n10 = rnd.Next(1, 10);
            int n11 = rnd.Next(1, 10);
            int n12 = rnd.Next(1, 10);
            List<int> numbers = new List<int> { n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12 };
            sum_chet = 0;
            for (int i = 1; i < numbers.Count; i += 2)
            {
                sum_chet += numbers[i]
            }
            sum_nechet = 0;
            for (int i = 0; i < numbers.Count; i += 2)
            {
                sum_nechet += numbers[i]
            }
            int control_digit = (sum_chet * 3) + sum_nechet;
            Console.WriteLine(control_digit % 10);

            Console.ReadKey();
        }
    }
}
