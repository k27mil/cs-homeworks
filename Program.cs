using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_homeworks
{
    internal class Program
    {
        enum grubost
        {
            low,
            medium,
            hight
        }
        struct ded
        {
            public string name;
            public grubost level;
            public string[] phrasess;
            public int fingals;
            public static int CheckBadWords(ref ded grandpa, params string[] badwordss)
            {
                foreach (string phrase in grandpa.phrasess)
                {
                    foreach (string badword in badwordss)
                    {
                        if (phrase.ToLower().Contains(badword.ToLower()))
                        {
                            grandpa.fingals++;
                        }
                    }
                }
                return grandpa.fingals;
            }
        }

        static void Main(string[] args)
        {
            ded d1 = new ded { name = "Daun", level = grubost.hight, phrasess = new[] { "Суки!", "Проститутки!", "ЧМО!" } };
            ded d2 = new ded { name = "Daun2", level = grubost.hight, phrasess = new[] { "Суки!", "Проститутки!", "hello!" } };

            string[] badwordss = { "Суки!", "Проститутки!", "ЧМО!" };

            ded.CheckBadWords(ref d1, badwordss);
            ded.CheckBadWords(ref d2, badwordss);

            Console.WriteLine($"у {d1.name} фингалов {d1.fingals}");
            Console.WriteLine($"у {d2.name} фингалов {d2.fingals}");

        }
    }
}
