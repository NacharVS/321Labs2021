using System;

namespace Group321
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(500);
            Account acc1 = new Account(600);
            Operations.ShowMessage += ShowMess;
            Operations.Deposit(acc, 40);
            Operations.Transaction(acc, acc1, 40);
            Operations.Widtraw(acc, 40);
        }

        static void ShowMess(string mes)
        {
            Console.WriteLine(mes);
        }
    }
}