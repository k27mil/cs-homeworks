using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace cs_homeworks
{
    internal class Program
    {
        static bool factorial(int a, out int result)
        {
            result = 1;
            if (a < 0)
            {
                result = 0;
                return false;
            }
            try
            {
                checked
                {
                    for (int i = 1; i <= a; i++)
                    {
                        result *= i;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                result = 0;
                return false;
            }
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int result;
            if (factorial(x, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(factorial(x, out result));
            }
        }
    }
}
