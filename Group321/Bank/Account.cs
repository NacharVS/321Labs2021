using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Account
    {
        private double _balance;
        private double _creditBalance;


        public double Balance
        {
            get => _balance;
            set
            {
                _balance = value;
            }
        }

        public double CreditBalance
        {
            get => _creditBalance;
            set
            {
                _creditBalance = value;
            }
        }
    }

    class AccKlient : Account
    {
        string name;

    }

    class AccEmploer : Account
    {
        int id;
        string name;
        string login;
    }
}
