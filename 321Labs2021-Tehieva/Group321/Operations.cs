using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Operations
    {
        public static void ShowBalance(Account account)
        {
            Console.WriteLine("Balance:");
            System.Console.WriteLine($"YOUR BALANCE: {account.Ballance}");
        }
        public static void ShowBallanceCredit(CreditAccount account)
        {

            System.Console.WriteLine ($"BalanceCredeit:{account.BallanceCredit}");
        }

        public static void Transaction(Account accountSeller, Account accountGetter, double summ)
        {
            accountSeller.Ballance -= summ;
            accountGetter.Ballance += summ;
            System.Console.WriteLine("TRANSACTION COMPLETED");
            Console.WriteLine($"FIRST ACCOUNT : {accountSeller.Ballance} SECOND ACCOUNT: {accountGetter.Ballance}");
        }

        public static void Widtraw(Account accountSeller, double summ)
        {
            if (accountSeller.Ballance >= summ)
            {
                accountSeller.Ballance -= summ;
                System.Console.WriteLine("TRANSACTION COMPLETED");
                Console.WriteLine($"YOUR ACCOUNT HAS BEEN CHARGED: {summ} YOUR BALANCE: {accountSeller.Ballance}");
            }
            else
            {
                Console.WriteLine("THIS OPERATION IS IMPOSSIBLE!");
            }


        }

        public static void Deposit(Account accountGetter, double summ, int mounth)
        {
            if (summ > 0 && mounth > 0)
            {
                accountGetter.Ballance = accountGetter.Ballance + summ;
                Double result = Convert.ToDouble(accountGetter.Ballance);
                while (mounth > 0)
                {
                    result = result * 0.025 + accountGetter.Ballance;
                    mounth--;
                }
                Console.WriteLine($"Your account has been received {summ} Balance: {result}");
            }
            else
            {
                Console.WriteLine("The operation is not possible");
            }

        }

        public static void Credit(CreditAccount accountCred, double summCred, int mounth)
        {
            if (summCred > 0 && mounth > 0)
            {
                accountCred.BallanceCredit = accountCred.BallanceCredit + summCred;
                Double result = Convert.ToDouble(accountCred.BallanceCredit);
                while (mounth > 0)
                {
                    result = result * 0.07 + accountCred.BallanceCredit;
                    mounth--;
                }
                Console.WriteLine($"Your account has been received {summCred} Balance: {result}");
            }
            else
            {
                Console.WriteLine("The operation is not possible");
            }

        }



    }
}
