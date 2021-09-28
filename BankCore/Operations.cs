using System;
using System.Collections.Generic;
using System.Text;

namespace BankCore
{
    public class Operations
    {
        public static void ShowBallance(BankAccount account)
        {
            Console.WriteLine($"Your balance: {account.Ballance}$");
        }

        public static void Transaction(BankAccount accountSeller, BankAccount accountGetter, double sum)
        {
            if (accountSeller.Ballance < sum)
            {
                Console.WriteLine("Transaction failed! Insufficient funds");
            }
            else
            {
                accountSeller.Ballance -= sum;
                accountGetter.Ballance += sum;
                Console.WriteLine($"Transaction {sum}$ completed");
                Console.WriteLine($"Ballance seller: {accountSeller.Ballance}$ Ballance getter: {accountGetter.Ballance}$");
            }
        }

        public static void Deposit(BankAccount account, int sum)
        {
            var newSum = Convert.ToDouble(sum);
            account.Ballance += newSum;
        }

        public static void Widrtaw(BankAccount account, int sum)
        {
            if (account.Ballance < sum)
            {
                Console.WriteLine("Transaction failed! Insufficient funds");
            }
            else
            {
                var newSum = Convert.ToDouble(sum);
                account.Ballance -= newSum;
            }
        }

        public static void Credit(BankAccount account, double sum)
        {
            account.CreditBallance += sum;
            account.Ballance += sum;
        }

        public static void Start()
        {
            Console.WriteLine("Starting program...");
        }
    }
}
