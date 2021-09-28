using System;
using System.Collections.Generic;
using System.Text;

namespace bank1
{
    public class Account
    {
        public Account (double balance)
        {
            this.balance = balance;
        }
        public Account()
        {

        }
        protected static double creditStavka;
        protected double balance;
        protected double zadoljnost;
        protected double _id;
        public double Persent
        {
            get; set;
        }
        public string id
        {
            get; set;
        }
        public double CreditSher
        {
            get; set;
        }
        public static double creditSher = 5.7;
        public double Balance { get => balance; set => balance = value; }
        public virtual double CreditStavka { get => creditStavka; set => creditStavka = value; }

        public double Zadoljnost { get; set; }

        
    }
}
