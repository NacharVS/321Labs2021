using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Operations
    {
        public static void ShowBalanse(Account account)
        {
            Console.WriteLine(account.Balanse);
        }
        public static void Transaction(Account accountSeller, Account accountGetter, double summ)
        {
            accountSeller.Balanse -= summ;
            accountGetter.Balanse += summ;
            Console.WriteLine("Complited");
            Console.WriteLine($"balanse sell", accountSeller.Balanse, $"balanse det", accountGetter.Balanse);

        }

        public static int Widrtaw(Account account, double summ)
        {
            account.Balanse -= summ;
            return (int)summ;
            //Console.WriteLine(account.Balanse);
        }

        public static int Deposit(Account account, double summ)
        {
            account.Balanse += summ;
            return (int)summ;
            //Console.WriteLine(accountMoney.Balanse);
        }

        public static int SberRate(Account account)
        {
            return summ;
        }

    }
}
