using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group321
{
    class Account
    {
        protected double balanceDollar;
        protected double balanceRubles;
        protected double credit = 0;
        protected double vklad = 0;
        protected static double procentStavkaCredit = 7;
        protected static double procentStavkaVklad = 3;
        protected PersonalData persondata;

        public double Balance { get => balanceRubles; set => balanceRubles = value; }
        public double BalanceDollar { get => balanceDollar; set => balanceDollar = value; }
        public double Credit { get => credit; set => credit = value; }
        public double Vklad { get => vklad; set => vklad = value; }

        public virtual PersonalData PD { get => persondata; set => persondata = value; }
        public virtual double ProcentStavkaCredit { get => procentStavkaCredit; set => procentStavkaCredit = value; }
        public virtual double ProcentStavkaVklad { get => procentStavkaVklad; set => procentStavkaVklad = value; }


        public Account()
        {

        }

        public Account(double balance, PersonalData pd)
        {
            balanceRubles = balance;
            balanceDollar = Math.Round(balance / 73.08, 3);
            persondata = pd;
        }

        public Account(double dollar, double rubles, PersonalData pd)
        {
            balanceDollar = dollar;
            balanceRubles = rubles;
            persondata = pd;
        }
    }
}
