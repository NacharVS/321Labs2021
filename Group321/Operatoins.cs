using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Operations
    {
        public static void ShowBallance(Account account)
        {
            Console.Write("Balans: ");
            System.Console.WriteLine(account.Ballance);
        }
        public static void Transaction(Account accountSeller, Account accountGetter, double summ)
        {
            if (accountSeller.Ballance >= summ && summ > 0)
            {
                accountSeller.Ballance -= summ;
                accountGetter.Ballance += summ;
                System.Console.WriteLine("Transaction completed: ");
                Console.WriteLine($"accountSeller Balans:{accountSeller.Ballance} transact {summ} accountGetter Balans:{accountGetter.Ballance}");
            }
            else
                Console.Write("The operation is not possible!");
        }
        public static void Widtraw(Account accountWid, double summ)
        {
            if (accountWid.Ballance >= summ && summ > 0)
            {
                accountWid.Ballance -= summ;
                System.Console.WriteLine("Widtraw completed: ");
                Console.WriteLine($"Your account has been withdrawn {summ} Balans:{accountWid.Ballance} ");
            }
            else
            {
                Console.Write("The operation is not possible!");
            }
        }
        public static void Deposit(Account accountDep, double summ, int mounth)
        {
            if (summ > 0 && mounth > 0)
            {
                accountDep.Ballance = accountDep.Ballance + summ;
                double result = Convert.ToDouble(accountDep.Ballance);
                while (mounth > 0)
                {
                    result = result * 0.025 + accountDep.Ballance;
                    mounth--;
                }
                Console.WriteLine($"Your account has been received {summ} Balans:{result} ");

            }
            else
            {
                Console.Write("The operation is not possible!");
            }
        }
        public static void Credit(Account accountCred, double summ)
        {
            accountCred.Ballance += summ;
        }

    }
}
