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
        protected double balance;
        protected double zadoljnost;
        protected double _id;
        public static double _CreditStavka;
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
        public double Balance { get; set; }
        public virtual double CreditStavka { get => CreditStavka; set => CreditStavka = value; }

        public double Zadoljnost { get; set; }

        
    }
}
