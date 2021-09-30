using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    public class Account
    {
        private double balance;
        private int accountSeller;
        private int accountGetter;
        protected double _balance;
        public double Balance
        {
            get => _balance;
            set
            {
                _balance = value;
            }
        }
        private double rate;
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        private double _creditRate = 0.004;
        public virtual double CreditRate
        {
            get => _creditRate;
        }
    }
    public class Client : Account
    {
        private double _creditRate = 0.0031;
        public override double CreditRate
        {
            get => _creditRate;
        }
    }
    public class Employee : Account
    {
        private double _creditRate = 0.0025;
        public override double CreditRate
        {
            get => _creditRate;
        }
    }
}
