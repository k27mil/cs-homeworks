using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_homeworks
{
    internal class Program
    {
        enum schet
        {
            Current,
            Savings
        }
        struct bank
        {
            public string Number;
            public schet type;
            public int balance;
        }
        static void Main(string[] args)
        {
            bank account;

            account.Number = "123";
            account.type = schet.Current;
            account.balance = 999;

            Console.WriteLine(account.Number);
            Console.WriteLine(account.type);
            Console.WriteLine(account.balance);

            Console.ReadKey();
        }
    }
}
