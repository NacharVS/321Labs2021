using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Klient : Account
    {
        public override double StavkaCred { get => base.StavkaCred; set => base.StavkaCred = value; }
        public override double StavkaVklad { get => base.StavkaVklad; set => base.StavkaVklad = value; }

        public override PersonalData pd { get => base.pd; set => base.pd = value; }
        public Klient(double balance, PersonalData pd)
        {
            this.balance = balance;
            persd = pd;
            StavkaVklad = 5;
            StavkaCred = 7;
        }

        public Klient(double balance, PersonalData pd, double Credit, double Vklad, double timeVklad)
        {
            this.balance = balance;
            persd = pd;
            StavkaVklad = 5;
            StavkaCred = 7;
            this.Credit = Credit;
            this.Vklad = Vklad;
            this.timeVklad = timeVklad;
        }

        public Klient()
        {
           
        }
    }
}
