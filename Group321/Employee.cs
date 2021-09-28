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
        public override PersonalData PD { get => base.PD; set => base.PD = value; }

        public Employee()
        {
            ProcentStavkaCredit = 4;
            ProcentStavkaVklad = 7;
        }

        public Employee(double balance, PersonalData pd)
        {
            balanceRubles = balance;
            balanceDollar = balance / 73.08;
            ProcentStavkaCredit = 4;
            ProcentStavkaVklad = 7;
            PD = pd;
        }

        public Employee(double dollar, double rubles, PersonalData pd)
        {
            balanceDollar = dollar;
            balanceRubles = rubles;
            ProcentStavkaCredit = 4;
            ProcentStavkaVklad = 7;
            PD = pd;
        }
    }
}
