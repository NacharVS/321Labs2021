using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Account
    {
        protected double balance;
        private double credit;
        private double vklad;
        private double timevklad;
        private static double Stavka = 5;
        private static double stavkaCred = 5;
        public double Balance { get => balance; set => balance = value; }
        public double Credit { get => credit; set => credit = value; }
        public double Vklad { get => vklad; set => vklad = value; }
        public double timeVklad { get => timevklad; set => timevklad = value; }
        public virtual double StavkaVklad { get => Stavka; set => Stavka = value; }
        public virtual double StavkaCred { get => stavkaCred; set => stavkaCred = value; }

        public Account()
        {

        }
        public Account(double balance)
        {
            this.balance = balance;
        }
    }
}
