using System;

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
            balanceDollar = Math.Round(balance / 73.08, 2);
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

        public Employee(double balance, PersonalData pd, double credit, double vklad)
        {
            balanceRubles = balance;
            balanceDollar = Math.Round(balance / 73.08, 2);
            persondata = pd;
            Credit = credit;
            Vklad = vklad;
        }
    }
}
