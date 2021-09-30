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
        private double Stavka = 5;
        private double stavkaCred = 5;
        protected PersonalData persd;
        
        public double Balance { get => balance; set => balance = value; }
        public double Credit { get => credit; set => credit = value; }
        public double Vklad { get => vklad; set => vklad = value; }
        public double timeVklad { get => timevklad; set => timevklad = value; }
        public virtual double StavkaVklad { get => Stavka; set => Stavka = value; }
        public virtual double StavkaCred { get => stavkaCred; set => stavkaCred = value; }
        public virtual PersonalData pd  { get => persd; set => persd = value; }

        public Account()
        {

        }
        public Account(double balance, PersonalData pd)
        {
            this.balance = balance;
            persd = pd;
        }
        public Account(double balance, PersonalData pd, double Credit, double Vklad, double timeVklad)
        {
            this.balance = balance;
            persd = pd;
            this.Credit = Credit;
            this.Vklad = Vklad;
            this.timeVklad = timeVklad;
        }
    }
}
