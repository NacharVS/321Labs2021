using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Account
    {
        private double _balanse;

        public double Balanse
        {
            get => _balanse;
            set
            {
                _balanse = value;
            }
        }
        //public double Rate
        //{
        //    get => _rate;
        //    set
        //    {
        //        _rate = value;
        //    }
        //}

        public delegate void AccountHandler(string massage);
        public event AccountHandler Notify = (massage) =>
        {
            Console.WriteLine(massage);
        };

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

        public static void Transaction(Account accountSeller, Account accountGetter, double sum)
        {
            if (accountSeller.Balanse < sum)
            {
                Console.WriteLine("Transaction failed! Insufficient funds");
            }
            else
            {
                accountSeller.Balanse -= sum;
                accountGetter.Balanse += sum;
                Console.WriteLine($"Transaction {sum}$ completed");
                Console.WriteLine($"Balanse seller: {accountSeller.Balanse}$ Balanse getter: {accountGetter.Balanse}$");
                Notify?.Invoke($"Your balance: {accountSeller.Balanse}$");

            }
        }
    }

}
