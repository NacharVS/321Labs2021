﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group321
{
    class Operations
    {
        public delegate void AccountHandler(string message);
        public static event AccountHandler Notify = (message) =>
        {
            Console.WriteLine($"{message}");
        };
        public static void ShowBalance(Account acc)
        {
            acc.BalanceDollar = Math.Round(acc.Balance / 73.08, 3);
            Console.WriteLine($"Баланс в рублях {acc.Balance}, Баланс в долларах {acc.BalanceDollar}");
        }

        public static void Transaction(Account accSeller, Account accGetter, double sum)
        {
            if (accSeller.Balance >= sum)
            {
                accSeller.Balance -= sum;
                accGetter.Balance += sum;
                Notify?.Invoke($"Было переведено {0} рублей. Ваш баланс: {accSeller.Balance}");
                Console.WriteLine("Transaction completed");
            }
            else
            {
                Console.WriteLine("Transaction failed");
            }
        }

        public static int Widtraw(Account acc, double widtrawSum) //снять деньги
        {
            if (widtrawSum < acc.Balance)
            {
                acc.Balance -= (int)widtrawSum;
                Notify?.Invoke($"Было снято {widtrawSum}. Ваш баланс: {acc.Balance}");
                return (int)widtrawSum;
            }
            else
                Console.WriteLine("Не хватает денег на балансе");

            return 0;
        }

        public static int Deposit(Account accGetter, double sum)
        {
            if (sum > 0)
            {
                accGetter.Balance += sum;
                Notify?.Invoke($"Был взят {sum} рублей. Ваш баланс: {accGetter.Balance}");
                return (int)sum;
            }
            return 0;
        }

        public static void GetCredit(Account acc, int mounthCount, double creditSum)
        {
            if (acc.Credit == 0)
            {
                acc.Balance += creditSum;
                double balance = acc.Balance;
                double rascredit;
                for (int i = 1; i < mounthCount + 1; i++)
                {
                    rascredit = CalculateCredit(balance, acc.ProcentStavkaCredit);
                    balance += rascredit;
                    Console.WriteLine($"{i} месяц {rascredit} рублей");
                }
                acc.Credit = balance;
                Console.WriteLine($"Сумма возврата составляет {balance} рублей со всеми процентами");
            }
            else
            {
                Console.WriteLine("Кредит не одобрен, так как кредит уже выдан");
            }
        }

        public static void PayCredit(Account acc, double repaymentSum)
        {
            if (acc.Credit != 0 && acc.Balance >= repaymentSum && acc.Credit >= repaymentSum)
            {
                acc.Balance -= repaymentSum;
                acc.Credit -= repaymentSum;
                Console.WriteLine($"Остаток кредита = {acc.Credit} Остаток баланса = {acc.Balance}");
            }
            else
            {
                Console.WriteLine("Не удалось погасить кредит, проверьте баланс");
            }
        }

        private static double CalculateCredit(double creditSum, double procentStavka)
        {
            double res = (creditSum * procentStavka) / 100;
            return res;
        }

        public static void Vklad(Account acc, double vkladSum, int mounthCount)
        {
            if (vkladSum > acc.Balance)
            {
                Console.WriteLine("Сумма вкада не может быть больше чем баланс");
            }

            else
            {
                acc.Balance -= vkladSum;
                acc.Vklad = vkladSum;
                double balance = vkladSum;
                double rascredit;

                for (int i = 1; i < mounthCount + 1; i++)
                {
                    rascredit = CalculateCredit(balance, acc.ProcentStavkaVklad);
                    balance += rascredit;
                    Console.WriteLine($"{i} месяц {rascredit} рублей");
                }

                Console.WriteLine($"Сумма вклада составляет {balance} рублей со всеми процентами");
            }
        }
    }
}
