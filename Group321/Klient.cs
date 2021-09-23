using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Klient : Account
    {
        public override double StavkaCred { get => base.StavkaCred; set => base.StavkaCred = value; }
        public override double StavkaVklad { get => base.StavkaVklad; set => base.StavkaVklad = value; }
        public Klient(double balance)
        {
            this.balance = balance;
        }

        public Klient()
        {
            StavkaVklad = 5;
            StavkaCred = 7;
        }
    }
}
