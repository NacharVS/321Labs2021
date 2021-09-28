namespace Group321
{
    class Client : Account
    {
        public override double ProcentStavkaCredit { get => base.ProcentStavkaCredit; set => base.ProcentStavkaCredit = value; }
        public override double ProcentStavkaVklad { get => base.ProcentStavkaVklad; set => base.ProcentStavkaVklad = value; }
        public override PersonalData PD { get => base.PD; set => base.PD = value; }

        public Client()
        {

            ProcentStavkaCredit = 7;
            ProcentStavkaVklad = 3;
        }

        public Client(double balance, PersonalData pd)
        {
            balanceRubles = balance;
            balanceDollar = balance / 73.08;
            ProcentStavkaCredit = 7;
            ProcentStavkaVklad = 3;
            PD = pd;
        }

        public Client(double dollar, double rubles, PersonalData pd)
        {
            balanceDollar = dollar;
            balanceRubles = rubles;
            ProcentStavkaCredit = 7;
            ProcentStavkaVklad = 3;
            PD = pd;
        }
    }
}
