using System;

namespace bank1
{
    class Programbalance
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account();
            Account acc2 = new Account();
            acc1.Balance = 170000;
            acc2.Balance = 12000;
            Console.WriteLine("Сумма Первого аккаунта:" + acc1.Balance);
            Console.WriteLine("Сумма Второго аккаунта:" + acc2.Balance);
            Operation.Transaction(acc1, acc2, 1500);
            Operation.Widthraw(acc1, 2000);
            Operation.Deposit(acc1, 6000);
        }
    }
}