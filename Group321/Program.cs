using System;

namespace Group321
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            Account acc2 = new Account();
            Account acc3 = new Account();
            Account acc4 = new Account();
                //AccountCredit acre = new AccountCredit();
            acc.Ballance = 10000;
            acc2.Ballance = 10500;
            acc3.Ballance = 12000;
            acc4.Ballance = 12000.00;
            Operations.ShowBallance(acc);
                //Operations.ShowBallanceCredit(acre);
            Operations.Transaction(acc, acc2, 2000.00);
            Operations.Widtraw(acc3, 2000.00);
            Operations.Deposit(acc4, 2000.00, 4);

        }
    }    
}
