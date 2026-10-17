using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_homeworks
{
    internal class Program
    {
        static int calculate(ref long product, out double average, params int[] numbers)
        {
            int sum = 0;
            product = 1;

            foreach (int number in numbers)
            {
                sum += number;
                product *= number;
            }

            average = (double)sum / numbers.Length;

            return sum;
        }

        static void Main()
        {

            int[] numbers = { 2, 3, 4, 5 };
            long product = 1;

            int sum = calculate(ref product, out double average, numbers);

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product}");
            Console.WriteLine($"Среднее арифметическое: {average}");
        }

    }
}
