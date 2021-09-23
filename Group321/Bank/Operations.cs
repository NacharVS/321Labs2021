using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Operations
    {
        private static double interestRate;

        public static double InterestRate { get; set; }
        public static void ShowBalance(AccKlient account)
        {
            Console.WriteLine(account.Balance);
        }

        public static void ShowBalance(AccEmploer account)
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

        public static int Widtraw(AccKlient account, double summ)     //Снятие наличных
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

        public static int Widtraw(AccEmploer account, double summ)     //Снятие наличных
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

        public static double TakeDeposit(AccKlient account)     //Вклад
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

        public static double TakeDeposit(AccEmploer account)     //Вклад
        {
            Console.WriteLine("Введите кол-во дней");
            int manthDay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма вклада");
            int summ = Convert.ToInt32(Console.ReadLine());

            account.Balance += summ;
            InterestRate = 0.05;
            account.Balance += (account.Balance * InterestRate * manthDay / 365) / 100;

            return account.Balance;
        }

        public static void TakeCredit(AccKlient account)
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

        public static void TakeCredit(AccEmploer account)
        {
            Console.WriteLine("Введите кол-во дней");
            int manthCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сумма вклада");
            int summ = Convert.ToInt32(Console.ReadLine());
            account.CreditBalance += summ;
            InterestRate = 0.03;
            account.CreditBalance -= (summ * InterestRate / 12) * manthCount;

            Console.WriteLine(account.CreditBalance);
        }

        void StartProgram()
        {
            List<PersonalData> acc = new List<PersonalData>();
            acc.Add(new PersonalData("Ivan", "Ivanov", "Kazan", new AccKlient()));
            acc.Add(new PersonalData("Maria", "Ivanova", "Kazan", new AccKlient()));
            acc.Add(new PersonalData("Roys", "Garianova", "Kazan", new AccKlient()));
            acc.Add(new PersonalData("Vlad", "Brednov", "Kazan", new AccEmploer()));
            acc.Add(new PersonalData("Danila", "Mansyrova", "Kazan", new AccEmploer()));
        }

        public void Clear()
        {

        }
    }
}
