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
        private int creditBalance;
        public double Balance { get; set; }
        private double rate;
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
    }
    public class Client : Account
    {
        private double _creditRate;
        public double creditRate
        {
            get => 0.01;
        }
    }
    public class Employee : Account
    {
        private double _creditRate;
        public double creditRate
        {
            get => 0.008;
        }
    }
}
