using System;
using bank1;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    public class Employee : Account
    {
        public override double CreditStavka { get => base.CreditStavka; set => base.CreditStavka = value; }

        public Employee()
        {
            CreditStavka = 5.7;
        }

        public Employee(double balance)
        {
            CreditStavka = 5.7;
            this.balance = balance;
        }
    }
}
