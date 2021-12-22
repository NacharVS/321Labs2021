using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            Account acc2 = new Account();
            //Account accountMoney = new Account();
            acc2.Balanse = 1000;
            acc.Balanse = 1000;
            Operations.ShowBalanse(acc);
            Operations.Transaction(acc, acc2, 5000);
            Operations.Widrtaw(acc, 300); //
        }
    }
}
