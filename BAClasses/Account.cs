using System;

namespace BAClasses
{
    public class Account
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

        private double _credit;
        public double CreditBalance
        {
            get => _credit;
            set
            {
                _credit = value;
            }
        }

        private static double _intRate;
        public double InterRate
        {
            get => _intRate;
            set
            {
                _intRate = value;
            }
        }
    }
}
