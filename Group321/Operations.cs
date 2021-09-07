using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1
{
    class Operations
    {
        public static void ShowBallance (BankAccount bankAccount)
        {
            Console.WriteLine(bankAccount.Ballance);
        }

        public static void Transaction(BankAccount bankAccount, BankAccount bankAccount1, double sum)       
        {
            bankAccount1.Ballance += sum;
            bankAccount.Ballance -= sum;
            Console.WriteLine($"Транзакция выполнена: {sum}", sum);
        }

        public static void Withdraw(BankAccount bankAccount, double sum)
        {
            double result = 0;
            if (bankAccount.Ballance >= sum)
            {
                bankAccount.Ballance -= sum;
                result = sum;
                Console.WriteLine($"Сумма {sum} снято со счета", sum);
            }
            else
            {
                Console.WriteLine("Недостаточно денег на счету");
            }
        }

        public static void Calculate(BankAccount bankAccount)
        {
            double increment = bankAccount.Ballance * bankAccount.Percent / 100;
            bankAccount.Ballance = bankAccount.Ballance + increment;
            Console.WriteLine($"Начислены проценты в размере: {increment}", increment);
        }

        public static void GetCredit(BankAccount bankAccount, double payment)
        {
            double creditSum = bankAccount.Ballance;
            double indebtedness = 0;
            double overpay = 0;

            if (payment > creditSum)
            {
                overpay = payment - creditSum;
                Console.WriteLine($"Кредит погашен");
                Console.WriteLine($"Переплата по ставке: {overpay}", overpay);
            }
            else if (payment == creditSum)
            {
                Console.WriteLine($"Кредит погашен");
            }
            else
            {
                indebtedness  = creditSum - payment;
                Console.WriteLine($"Задолжность составляет: {indebtedness}", indebtedness);
            }

        }

    }
}
