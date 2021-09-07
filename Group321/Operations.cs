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

        public static void Transaction(BankAccount bankAccount, double sum)       
        {
            bankAccount.Ballance += sum;
            Console.WriteLine("Транзакция выполнена");
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

        public static void GetCredit(BankAccount bankAccount, double creditSum)
        {
            
        }

    }
}
