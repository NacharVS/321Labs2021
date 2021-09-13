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

        private double _creditRate = 0.057;
        public virtual double CreditRate
        {
            get => _creditRate;
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
        private double _creditRate = 0.046;
        public override double CreditRate
        {
            get => _creditRate;
        }
    }

    public class Employee : Account
    {
        private double _creditRate = 0.04;
        public override double CreditRate
        {
            get => _creditRate;
        }
    }
}
