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
            //int[] days = { 1, 2, 3, 4, 5, 4, 6 };
            //for (int i = 0; i < (days.Length - 1); i++)
            //{
            //    if (days[i] > days[i + 1])
            //    {
            //        Console.WriteLine(i + 1); break;
            //    }
            //}
            //Console.ReadKey();




            //int k = int.Parse(Console.ReadLine());
            //try
            //{
            //    switch (k)
            //    {
            //        case 6: Console.WriteLine("шестерка"); break;
            //        case 7: Console.WriteLine("семерка"); break;
            //        case 8: Console.WriteLine("восьмерка"); break;
            //        case 9: Console.WriteLine("девятка"); break;
            //        case 10: Console.WriteLine("десятка"); break;
            //        case 11: Console.WriteLine("валет"); break;
            //        case 12: Console.WriteLine("дама"); break;
            //        case 13: Console.WriteLine("король"); break;
            //        case 14: Console.WriteLine("туз"); break;
            //    }
            //    if ((k < 6) || (k > 14))
            //    {
            //        throw new Exception("Out of range");
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine($"Ошибка: Неверный формат");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Ошибка: {e.Message}");
            //}



            string word = Console.ReadLine();
            switch (word)
            {
                case "Jabroni": Console.WriteLine("Patron Tequila"); break;
                case "School Counselor": Console.WriteLine("Anything with alcohol"); break;
                case "Programmer": Console.WriteLine("Hipster craft beer"); break;
                case "Bike gang member": Console.WriteLine("Moonshine"); break;
                case "Politician": Console.WriteLine("Your tax dollars"); break;
                case "Rapper": Console.WriteLine("Cristal"); break;
                case "anything else": Console.WriteLine("beer"); break;
            }
        }
        
    }
}

