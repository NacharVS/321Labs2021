using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group321
{
    class Client : Account
    {
        public override double ProcentStavkaCredit { get => base.ProcentStavkaCredit; set => base.ProcentStavkaCredit = value; }
        public override double ProcentStavkaVklad { get => base.ProcentStavkaVklad; set => base.ProcentStavkaVklad = value; }

        public Client()
        {

        }

        public Client(double balance)
        {
            balanceRubles = balance;
            balanceDollar = balance / 73.08;
        }

        public Client(double dollar, double rubles)
        {
            balanceDollar = dollar;
            balanceRubles = rubles;
        }
    }
}
