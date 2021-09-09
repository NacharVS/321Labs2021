using System;
using System.Collections.Generic;
using System.Text;

namespace bank1
{
    class Operation
    {
        public static void ShowBalance(Account acc)
        {
            Console.WriteLine(acc.Balance);
        }
        public static void Transaction(Account acc, Account acc1, double sum)
        {
            acc.Balance -= sum;
            acc1.Balance += sum;
            Console.WriteLine("Транзакция выполнена!");
        }
        public static int Widthraw(Account account, double sum)
        {
            if (sum % 1 < 1)
            {
                account.Balance -= sum;
                Console.WriteLine("Сумма списания:" +  sum , "Руб!");
                Console.WriteLine("Баланс после списания:" +  account.Balance , "Руб!");
            }
            return 0;
        }
        public static int Deposit(Account accountgetter, double sum)
        {
            accountgetter.Balance += sum;
            Console.WriteLine("Депозит прошёл успшно!");
            return 0;
        }
        public static int Credit(Account account, double CreditStavka, double sum)
        {
            double kolvodney = Convert.ToDouble(Console.ReadLine());
            account.Balance += sum;
            account.CreditSher = (sum * CreditStavka / 15) * kolvodney;
            return 0;
        }
    }
}
