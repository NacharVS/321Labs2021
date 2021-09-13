using System;
using System.Collections.Generic;
using System.Text;

namespace BAClasses
{
    public class Operation
    {
        public static void ShowBalance(Account account)
        {
            Console.WriteLine($"Your balance: {account.Balance}");
        }

        public static void Transaction(Account sender, Account accepter, double amount)
        {
            if (sender.Balance < amount)
            {
                Console.WriteLine("Transaction abbondoned");
            }
            sender.Balance -= amount;
            accepter.Balance += amount;

            Console.WriteLine($"Transaction has been completed");
        }

        public static void Deposite(Account account, double amount)
        {
            if (amount % 50 != 0)
            {
                Console.WriteLine("You can not deposite kopeykas");
            }
        }

        public static void InterestRate(double amount, int monthCnt, Account account)
        {

            if (amount < 0)
            {
                Console.WriteLine("It's not enough money on your wallet");
            }

            Convert.ToDouble(monthCnt);
            account.InterRate = 0.057;
            double income = (amount * account.InterRate / 12) * monthCnt;
            Console.WriteLine($"Your income is {income}, your total amount is {income + amount}");
        }

        public static void CreditCalculator(Account account, int cntMonth)
        {
            double prcntPerMonth = account.CreditRate / 12;
            double creditDebt = account.CreditBalance * (prcntPerMonth + (prcntPerMonth / (Math.Pow((1 + prcntPerMonth), cntMonth) - 1)));
            Console.WriteLine($"Your credit pay is {creditDebt} monthly");
            
        }

        /*public static void Credit(Account account, double amount, int months, int monthPaid)
        {
            double ppm = (amount / months);
            double remains = account.CreditBalance;

            for(int i = 0; i < monthPaid; ++i)
            {
               remains = amount - (ppm + (ppm * account.CreditRate));
            }
        }*/
    }
}
