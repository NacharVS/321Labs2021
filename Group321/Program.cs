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
            CreditAccount acre = new CreditAccount();
            acc.Ballance = 10000;
            acc2.Ballance = 10500;
            acc3.Ballance = 12000;
            acc4.Ballance = 12000.00;
            Operations.ShowBallance(acc);
            Operations.ShowBallanceCredit(acre);
            Operations.Transaction(acc, acc2, 2000.00);
            Operations.Widtraw(acc3, 2000.00);
            Operations.Deposit(acc4, 2000.00, 4);
            Operations.Credit(acre, 2000.00, 4);
            PersonalData.SotBanka();
            PersonalData.ClientBanka();

            Client num1 = new Client();
            PersonalData.Insert(num1,"Ермаков", "Роман", "01.03.1971", 75090.64);
        }
    }    
}
