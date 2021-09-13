using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    public class Employee : Account
    {
        public override double CreditStavka { get => base.CreditStavka; set => base.CreditStavka = value; }

        public Employee()
        {
            creditStavka = 0.6;
        }

        public Employee(double balance)
        {
            creditStavka = 0.6;
            this.balance = balance;
        }
    }
}
