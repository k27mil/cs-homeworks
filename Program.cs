using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_homeworks
{
    internal class Program
    {
        enum VUZ
        {
            KPFU,
            KAI,
            KHTI
        }
        struct people
        {
            public string name;
            public VUZ place;
        }
        static void Main(string[] args)
        {
            people bro;
            bro.name = "Alfred";
            bro.place = VUZ.KPFU;

            Console.WriteLine(bro.name);
            Console.WriteLine(bro.place);

            Console.ReadKey();
        }
    }
}
