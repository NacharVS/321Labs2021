using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Operations
    {
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
                // Console.WriteLine($"Было переведено {sum} рублей. Ваш баланс: {accSeller.Balance}");
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
                //ShowMessage?.Invoke($"Был взят {sum} рублей. Ваш баланс: {accGetter.Balance}");
                return (int)sum;
            }
            return 0;
        }

        public static int Widtraw(Account acc, double widtrawSum) //снять деньги
        {
            if (widtrawSum < acc.Balance)
            {
                acc.Balance -= (int)widtrawSum;
                //ShowMessage?.Invoke($"Было снято {widtrawSum} рублей. Ваш баланс: {acc.Balance} рублей");
                return (int)widtrawSum;
            }
            else
                Console.WriteLine("Не хватает денег на балансе");

            return 0;
        }
    }
}
