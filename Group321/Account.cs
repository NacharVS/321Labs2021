using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group321
{
    class Account
    {
        private double balanceDollar;
        private double balanceRubles;
        private double credit = 0;
        private double vklad = 0;
        private double procentStavkaCredit = 7;
        private double procentStavkaVklad = 3;

        public double Balance { get => balanceRubles; set => balanceRubles = value; }
        public double BalanceDollar { get => balanceDollar; set => balanceDollar = value; }
        public double Credit { get => credit; set => credit = value; }
        public double Vklad { get => vklad; set => vklad = value; }

        public virtual double ProcentStavkaCredit { get => procentStavkaCredit; set => procentStavkaCredit = value; }
        public virtual double ProcentStavkaVklad { get => procentStavkaVklad; set => procentStavkaVklad = value; }


        public Account()
        {

        }

        public Account(double balance)
        {
            balanceRubles = balance;
            balanceDollar = balance / 73.43;
        }

        public Account(double dollar, double rubles)
        {
            balanceRubles = rubles;
            balanceDollar = dollar;
        }
    }
}
