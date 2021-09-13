﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Operation
    {
       public static void ShowBalance(Account account)
       {
            Console.WriteLine(account.Balance);
       }
       public static void Transaction(Account accountSeller, Account accountGetter, double sum)
       {
            if (sum > accountSeller.Balance) 
            { 
                Console.WriteLine("Transaction failed"); 
            }
            else
            {
                accountSeller.Balance -= sum;
                accountGetter.Balance += sum;
                System.Console.WriteLine("Translation completed");
            }
       }

        public static int Widtraw(Account account, double sum)
        {
            int summ = Convert.ToInt32(sum);
            if (account.Balance >= sum)
            {
                account.Balance -= summ;
                System.Console.WriteLine("WidTraw completed");
                return summ;
            }
            else
            {
                Console.WriteLine("WidTraw failed");
            }
            return 0;
        }
        public static void Deposit(Account account, double sum)
        {
            account.Balance += sum;
            System.Console.WriteLine("Deposit completed");
        }

        public static void GetCredit(Account account, double time, double creditSum)
        {
            account.Balance += creditSum;
            account.Credit = creditSum + (creditSum / 100) * (StavkaCred * time);
        }

        public static void Invest(Account account, double sumvklad)
        {
            if (account.Balance >= sumvklad)
            {
                account.Balance -= sumvklad;
                account.Vklad += sumvklad;
                Console.WriteLine("Invest completed");
                Console.WriteLine($"Invest account = {account.Vklad}. After the expiration of the time, your account will have {account.Vklad + ((account.Vklad / 100) * (account.timeVklad * Stavka))}");

            }
            else
            {
                Console.WriteLine("Invest not completed");
            }

        }
        public static void PaymentCredit(Account account, double sum)
        {
            if ((account.Balance >= sum) && (account.Credit >= sum))
            {
                account.Balance -= sum;
                account.Credit -= sum;
                Console.WriteLine($"Payment completed.Your debt is {account.Credit}");
            }
            else
            {
                Console.WriteLine("Payment failed");
            }
        }
    }
}
