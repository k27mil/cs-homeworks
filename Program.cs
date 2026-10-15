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
            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 100);
            }
            Console.WriteLine(string.Join(" ", numbers));
            numbers[0] = int.Parse(Console.ReadLine());
            numbers[1] = int.Parse(Console.ReadLine());
            int x = numbers[0];
            numbers[0] = numbers[1];
            numbers[1] = x;
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
