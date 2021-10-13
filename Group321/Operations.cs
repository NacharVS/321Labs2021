﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Operations
    {
        public static void ShowBalance(Account account)
        {
            System.Console.WriteLine(account.Balance);
        }

        public static void Transaction(Account accountSeller, Account accountGetter, double sum)
        {
            if (accountGetter.Balance >= sum && accountSeller.Balance >= sum)
            {
                accountSeller.Balance -= sum;
                accountGetter.Balance += sum;
                System.Console.WriteLine("Транзакция завершена" + ' ' + sum);
            }
            else
            {
                Console.WriteLine("Вы не можете переводить деньги :(");
            }
            System.Console.WriteLine("Баланс первого счета: " + accountSeller.Balance + " Остаток на втором счете: " + accountGetter.Balance);
        }

        public static void Withdraw(Account account, double sum)
        {
            if (sum % 1 > 1)
            {
                account.Balance -= sum;
                System.Console.WriteLine("Witdraw of " + sum + " complete");
                System.Console.WriteLine("New Balance: " + account.Balance);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public static void Deposit(Account account, double sum, int monthCount)
        {
            account.Rate = 0.057;
            account.Balance = (sum * account.Rate / 12) * monthCount + sum;
            System.Console.WriteLine("Новый Баланс: " + account.Balance);
        }
        public static void Credit(Account account, double sum, int countMonth, double balance)
        {
            double prcntMonth = account.CreditRate / 12;
            balance = sum * (prcntMonth + (prcntMonth / (Math.Pow(1 + prcntMonth, countMonth) - 1)));
            Console.WriteLine($"Ваш ежемесячный платеж {balance}");
        }
    }
}
