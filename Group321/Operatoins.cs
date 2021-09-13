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

        public static void ShowBallanceCredit(CreditAccount account)
        {
            Console.Write("BallanceCredit: ");
            System.Console.WriteLine(account.BallanceCredit);
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
        public static void Credit(CreditAccount accountCred, double summCred, int mounth)
        {
            if (summCred > 0 && mounth > 0)
            {
                accountCred.BallanceCredit = accountCred.BallanceCredit + summCred;
                double result = Convert.ToDouble(accountCred.BallanceCredit);
                while (mounth > 0)
                {
                    result = result * 0.07 + accountCred.BallanceCredit;
                    mounth--;
                }
                Console.WriteLine($"You have taken out a loan for the amount of {summCred} Your debt through will be  BalansCredit:{result} ");
            }
            else
            {
                Console.Write("The operation is not possible!");
            }
        }

    }
}
