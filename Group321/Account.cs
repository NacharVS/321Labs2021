using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Account
    {
        private double balance;
        public double Balance { get => balance; set => balance = value; }

        public Account(double sum)
        {
            balance = sum;
        }
    }
}
