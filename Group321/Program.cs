using System;

namespace Group321
{
    public delegate void MessageBalance(string message);
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(500);
            Account acc1 = new Account(600);
            Operations.ShowMessage += ShowMess;
            Operations.Deposit(acc, 40);
            Operations.Transaction(acc, acc1, 40);
            Operations.Widtraw(acc, 40);
        }

        static void ShowMess(string mes)
        {
            Console.WriteLine(mes);
        }
    }

    class Account
    {
        private double balance;
        public double Balance { get => balance; set => balance = value; }

        public Account(double sum)
        {
            balance = sum;
        }
    }

    class Operations
    {
        public static event MessageBalance ShowMessage;
        public static void ShowBalance(Account acc)
        {
            Console.WriteLine($"Баланс в рублях {acc.Balance}");
        }


        public static void Transaction(Account accSeller, Account accGetter, double sum)
        {
            if (accSeller.Balance >= sum)
            {
                accSeller.Balance -= sum;
                accGetter.Balance += sum;
                ShowMessage?.Invoke($"Было переведено {sum} рублей. Ваш баланс: {accSeller.Balance}");
                Console.WriteLine("Transaction completed");
            }
            else
            {
                Console.WriteLine("Transaction failed");
            }
        }

        public static int Deposit(Account accGetter, double sum)
        {
            if (sum > 0)
            {
                accGetter.Balance += sum;
                ShowMessage?.Invoke($"Был взят {sum} рублей. Ваш баланс: {accGetter.Balance}");
                return (int)sum;
            }
            return 0;
        }

        public static int Widtraw(Account acc, double widtrawSum) //снять деньги
        {
            if (widtrawSum < acc.Balance)
            {
                acc.Balance -= (int)widtrawSum;
                ShowMessage?.Invoke($"Было снято {widtrawSum} рублей. Ваш баланс: {acc.Balance} рублей");
                return (int)widtrawSum;
            }
            else
                Console.WriteLine("Не хватает денег на балансе");

            return 0;
        }
    }
}