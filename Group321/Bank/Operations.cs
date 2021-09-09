using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Operations
    {
        private static double interestRate;

        public static double InterestRate { get; set; }
        public static void ShowBalance(Account account)
        {
            Console.WriteLine(account.Balance);
        }

        public static void Transaction(Account accountSeller, Account accountGetter, double summ)
        {
            if (accountSeller.Balance < 0)
            {
                Console.WriteLine("Недостаточно средств");
            }
            else
            {
                accountSeller.Balance -= summ;
                accountGetter.Balance += summ;
                Console.WriteLine($"balance sell - {accountSeller.Balance}, balance gett - {accountGetter.Balance}");
            }
        }

        public static int Widtraw(Account account, double summ)     //Снятие наличных
        {
            if (account.Balance < summ)
            {
                Console.WriteLine("Недостаточно средств");
            }
            else
            {
                account.Balance -= summ;
            }

            return (int)summ;
        }

        public static double TakeDeposit(Account account)     //Вклад
        {
            Console.WriteLine("Введите кол-во дней");
            int manthDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма вклада");
            int summ = Convert.ToInt32(Console.ReadLine());

            account.Balance += summ;
            InterestRate = 0.047;
            account.Balance += (account.Balance * InterestRate * manthDay / 365) / 100;

            return account.Balance;
        }

        public static void TakeCredit(Account account)
        {
            Console.WriteLine("Введите кол-во дней");
            int manthCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма вклада");
            int summ = Convert.ToInt32(Console.ReadLine());
            account.CreditBalance += summ;
            InterestRate = 0.057;
            account.CreditBalance -= (summ * InterestRate / 12) * manthCount;

            Console.WriteLine(account.CreditBalance);
        }
    }
}


