using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    public class Client : Account
    {
        public override double CreditStavka { get => base.CreditStavka; set => base.CreditStavka = value; }

        public Client()
        {
            creditStavka = 1.2;
        }

        public Client(double balance)
        {
            creditStavka = 1.2;
            this.balance = balance;
        }
    }
}
