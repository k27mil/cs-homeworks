using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cs_homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string stroka = Console.ReadLine();
            char[] chars = stroka.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = char.ToLower(chars[i]);
            }
                else if (char.IsLower(chars[i])
                {
                chars[i] = char.ToUpper(chars[i]);
            }
            string result = new string(chars);
            Console.WriteLine($"Результат: {result}");

            Console.ReadKey();
        }

    }
}
