using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    class Account
    {
        private double _balance;


        public double Balance
        {
            get => _balance;
            set
            {
                _balance = value;
            }
        }
    }
}
