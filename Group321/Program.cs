using System;

namespace bank1
{
    class Programbalance
    {
        static void Main(string[] args)
        {
            double sum = Convert.ToInt32(Console.ReadLine());
            Account acc1 = new Account()
            {
                id = "1337",
            };
            Console.WriteLine("Добро пожаловать клиент");
            Console.WriteLine($"Ваш персональный id: {acc1.id}", acc1.id);
            Account acc2 = new Account();
            acc1.Balance = 170000;
            acc2.Balance = 12000;
            Console.WriteLine("Сумма Первого аккаунта:" + acc1.Balance);
            Console.WriteLine("Сумма Второго аккаунта:" + acc2.Balance);
            Operation.Transaction(acc1, acc2, 1500);
            Operation.Widthraw(acc1, 2000);
            Operation.Deposit(acc1, 6000);
            Console.WriteLine("Кол-во дней");
            double kolvodney = Convert.ToDouble(Console.ReadLine());
            Operation.Credit(acc2, Account.creditSher, kolvodney, sum);
            Operation.Credit(acc2,  Account.creditSher, sum, 6000);

        }
    }
}