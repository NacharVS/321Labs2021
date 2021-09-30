using System;

namespace Group321
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            acc.Ballance = 10000;
            Operations.ShowBallance(acc);

            Account acc2 = new Account();
            acc2.Ballance = 10500;
            Operations.Transaction(acc, acc2, 2000.00);

            Account acc3 = new Account();
            acc3.Ballance = 12000;
            Operations.Widtraw(acc3, 2000.00);

            Account acc4 = new Account();
            acc4.Ballance = 12000.00;
            Operations.Deposit(acc4, 2000.00, 4);

            CreditAccount acre = new CreditAccount();
            Operations.Credit(acre, 2000.00, 4);
            Operations.ShowBallanceCredit(acre);            

            Personal per1 = new Personal(); 
            PersonalData.InsertPersonal(per1, 6, "Китова", "Анна", "19.06.1989", 11, "Операционист");
            
            Client cli1 = new Client();
            PersonalData.InsertClient(cli1,"Ермаков", "Роман", "01.03.1971", 75090.64);
        }
    }    
}
