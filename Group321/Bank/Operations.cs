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
            if(accountSeller.Balance < 0)
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

        public static int Deposit(Account account, double summ)     //Пополнение
        {
            account.Balance += summ;

            return (int)account.Balance;
        }

        public static void TakeCredit(Account account, double summ)
        {
            Console.WriteLine("Введите кол-во месяцев");
            account.Balance += summ;
            int manthCount = Convert.ToInt32(Console.ReadLine());
            InterestRate = 0.057;
            account.Balance -= (summ * InterestRate / 12) * manthCount;

            Console.WriteLine(account.Balance);
        }

        public static void Profit(Account account)      //Вклад
        {
            Console.WriteLine("Введите кол-во месяцев");
            int manthCount = Convert.ToInt32(Console.ReadLine());
            InterestRate = 0.035;
            account.Balance += (account.Balance * InterestRate / 12) * manthCount;

            Console.WriteLine(account.Balance);
        }
    }
}
