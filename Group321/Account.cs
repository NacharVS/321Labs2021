using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    public delegate void MessageBalance(string message);
    class Account
    {
        public event MessageBalance ShowMessage;
        private double balance;
        public double Balance { get => balance; set { balance = value; ShowMessage?.Invoke(balance.ToString()); } }

        public Account(double sum)
        {
            balance = sum;
        }
    }
}
