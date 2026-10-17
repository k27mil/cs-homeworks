using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cs_homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите число от 0 до 9: ");
                string input = Console.ReadLine();

                if (input == "exit" || input == "закрыть")
                    break;

                try
                {
                    int number = int.Parse(input);

                    if (number < 0 || number > 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка!");
                        Thread.Sleep(3000);
                        Console.ResetColor();
                    }
                    else
                    {
                        switch (number)
                        {
                            case 0: Console.WriteLine("###\n# #\n# #\n# #\n###\n"); break;
                            case 1: Console.WriteLine(" # \n## \n # \n # \n###\n"); break;
                            case 2: Console.WriteLine("###\n  #\n###\n#  \n###\n"); break;
                            case 3: Console.WriteLine("###\n  #\n###\n  #\n###\n"); break;
                            case 4: Console.WriteLine("# #\n# #\n###\n  #\n  #\n"); break;
                            case 5: Console.WriteLine("###\n#  \n###\n  #\n###\n"); break;
                            case 6: Console.WriteLine("###\n#  \n###\n# #\n###\n"); break;
                            case 7: Console.WriteLine("###\n  #\n  #\n  #\n  #\n"); break;
                            case 8: Console.WriteLine("###\n# #\n###\n# #\n###\n"); break;
                            case 9: Console.WriteLine("###\n# #\n###\n  #\n###\n"); break;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка: нужно ввести число!");
                }
            }
        }

    }
}
