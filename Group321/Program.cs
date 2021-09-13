using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            Account acc2 = new Account();
            acc.Ballance = 5000;
            acc2.Ballance = 8000;
            Operations.ShowBalance(acc);
            Operations.Transaction(acc, acc2, 500.00);
            Operations.Widtraw(acc, 500.00);
            Operations.Deposit(acc, 2000.00, 4);
        }
    }
}
