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
        //public static void Transaction(Account accountSeller, Account accountGetter, double sum)
        //{
        //    if (accountSeller.Balanse < sum)
        //    {
        //        Console.WriteLine("Transaction failed! Insufficient funds");
        //    }
        //    else
        //    {
        //        accountSeller.Balanse -= sum;
        //        accountGetter.Balanse += sum;
        //        Console.WriteLine($"Transaction {sum}$ completed");
        //        Console.WriteLine($"Balanse seller: {accountSeller.Balanse}$ Balanse getter: {accountGetter.Balanse}$");
        //    }
        //}

        //public static int Widrtaw(Account account, double summ)
        //{
        //    account.Balanse -= summ;
        //    return (int)summ;
        //    //Console.WriteLine(account.Balanse);
        //}

        //public static int Deposit(Account account, double summ)
        //{
        //    account.Balanse += summ;
        //    return (int)summ;
        //    //Console.WriteLine(accountMoney.Balanse);
        //}

    }
}
