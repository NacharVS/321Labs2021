using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    public class Account
    {
        protected double balance;
        protected int accountSeller;
        protected int accountGetter;
        protected static double creditStavka;

        public double Balance { get => balance; set => balance = value; }
        public double CreditShet { get; set; }
        public virtual double CreditStavka { get => creditStavka; set => creditStavka = value; }

        public Account()
        {

        }

        public Account(double balance)
        {
            this.balance = balance;
        }
    }
}
