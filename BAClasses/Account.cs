using System;

namespace BAClasses
{
    public class Account
    {
        private string _name;
        public virtual string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        private int _age;
        public virtual int Age
        {
            get => _age;
            set
            {
                _age = value;
            }
        }

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

    public class Client : Account, IClient
    {
        private string _name;
        public override string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        private int _age;
        public override int Age
        {
            get => _age;
            set
            {
                _age = value;
            }
        }

        private double _creditRate = 0.047;
        public override double CreditRate
        {
            get => _creditRate;
        }

        void IClient.ShowBalance()
        {
            throw new NotImplementedException();
        }

        void IClient.Transaction()
        {
            throw new NotImplementedException();
        }

        void IClient.Deposite()
        {
            throw new NotImplementedException();
        }
    }

    public class Employee : Account
    {
        private string _name;
        public override string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        private int _age;
        public override int Age
        {
            get => _age;
            set
            {
                _age = value;
            }
        }
        
        private double _creditRate = 0.04;
        public override double CreditRate
        {
            get => _creditRate;
        }
    }
}
