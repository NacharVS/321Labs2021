using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group321
{
    class Employee : Account
    {
        public override double ProcentStavkaCredit { get => base.ProcentStavkaCredit; set => base.ProcentStavkaCredit = value; }
        public override double ProcentStavkaVklad { get => base.ProcentStavkaVklad; set => base.ProcentStavkaVklad = value; }

        public Employee()
        {
            ProcentStavkaCredit = 4;
            ProcentStavkaVklad = 7;
        }

        public Employee(double balance)
        {
            balanceRubles = balance;
            balanceDollar = balance / 73.08;
            ProcentStavkaCredit = 4;
            ProcentStavkaVklad = 7;
        }

        public Employee(double dollar, double rubles)
        {
            balanceDollar = dollar;
            balanceRubles = rubles;
            ProcentStavkaCredit = 4;
            ProcentStavkaVklad = 7;
        }
    }
}
