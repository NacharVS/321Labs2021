using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount
            {
                Ballance = 1200,
                id = "12314dc",
                Percent = 0.057 
            };
            Operations.Transaction(bank, 100);
            Operations.Withdraw(bank, 100);
            Operations.Calculate(bank);
            Operations.ShowBallance(bank);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
