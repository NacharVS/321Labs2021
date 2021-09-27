using System;
using bank1;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
   public class Client : Account
    {
        public override double CreditStavka { get => base.CreditStavka; set => base.CreditStavka = value; }

        public Client()
        {
            CreditStavka = 5.7;
        }

        public Client(double balance)
        {
            CreditStavka = 5.7;
            this.balance = balance;
        }
    }
}
