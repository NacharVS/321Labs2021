using System;

namespace BAClasses
{
    public class Account
    {
        protected double _balance;
        public double Balance
        {
            get => _balance;
            set
            {
                _balance = value;
            }
        }

        protected double _credit;
        public double CreditBalance
        {
            get => _credit;
            set
            {
                _credit = value;
            }
        }

        protected double _creditRate;
        public virtual double CreditRate
        {
            get => 0;
        }


        protected static double _intRate;
        public double InterRate
        {
            get => _intRate;
            set
            {
                _intRate = value;
            }
        }
    }

    public class Client : Account
    {
        public override double CreditRate
        {
            get => 0.049;
        }
    }

    public class Employee : Account
    { 
        public override double CreditRate
        {
            get => 0.04;
        }
    }
}
