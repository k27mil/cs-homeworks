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
            Console.WriteLine("Введите номер дня в году:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год:");
            int y = int.Parse(Console.ReadLine());

            if (x >= 1 && x <= 366)
            {
                int[] month_days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                string[] month_names = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };

                if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                    month_days[1] += 1;

                int sum_days = 0;
                List<string> all_names = new List<string>();
                int round_days = 0;
                for (int i = 0; i < month_days.Length; i++)
                {
                    sum_days += month_days[i];
                    if (sum_days >= x)
                    {
                        round_days = sum_days - month_days[i];
                        all_names.Add(month_names[i]);
                        break;
                    }
                }
                int day = x - round_days;
                Console.WriteLine($"{day} {all_names[all_names.Count - 1]}");
            }
            else
            {
                Console.WriteLine("Дней в году 365!");
            }
            Console.ReadKey();
        }
    }
}
