using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Account
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;
        public Account(int sum, string userID, string name, string phonenumber)
        {
            Sum = sum;
            UserID = userID;
            Name = name;
            PhoneNumber = phonenumber;
        }
        public int Sum { get; private set; }
        public string UserID { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }


        //private double _balanse;

        //public double Balanse
        //{
        //    get => _balanse;
        //    set
        //    {
        //        _balanse = value;
        //    }
        //}
        //public double Rate
        //{
        //    get => _rate;
        //    set
        //    {
        //        _rate = value;
        //    }
        //}

        //var acc1 = new Account(sum, ID, name, number);
        //var acc2 = new Account(sum, ID, name, number);


        //public delegate void AccountHandler(string massage);
        //public event AccountHandler Notify;

        //public static string Notify
        //{
        //    get => Notify;
        //    set
        //    {
        //        Notify = Invoke(massage);
        //    }
        //}

        //public static void ShowBallance(Account account)
        //{
        //    Notify?.Invoke($"Your balance: {account.Balanse}$");
        //}

        //public Account(int sum, string userID, string name, string phonenumber)
        //{
        //    Sum = sum;
        //    UserID = userID;
        //    Name = name;
        //    PhoneNumber = phonenumber;
        //}

        //public int Sum { get; private set; }
        //public string UserID { get; private set; }
        //public string Name { get; private set; }
        //public string PhoneNumber { get; private set; }

        //public static void Transaction(Account accountSeller, Account accountGetter, double sum)
        //{
        //    if (accountSeller.Balanse < sum)
        //    {
        //        Console.WriteLine("Transaction failed! Insufficient funds");
        //    }
        //    else
        //    {
        //        accountSeller.Balanse -= sum;
        //        accountGetter.Balanse += sum;
        //        Console.WriteLine($"Transaction {sum}$ completed");
        //        Console.WriteLine($"Balanse seller: {accountSeller.Balanse}$ Balanse getter: {accountGetter.Balanse}$");
        //        Notify?.Invoke($"{accountSeller.Balanse}$");

        //    }
        //}

        //public static void ShowBallance(Account account)
        //{
        //    Notify?.Invoke($"Your balance: {account.Balanse}$");
        //}
    }

}

