using System;
using System.Collections.Generic;

namespace BankCore
{
    public class BankAccount
    {
        private PersonalData client;
        private int idAccount;

        private double _ballance;

        public double Ballance
        {
            get => _ballance;
            set
            {
                _ballance = value;
            }
        }

        private double _creditBallance;

        public double CreditBallance
        {
            get => _creditBallance;
            set
            {
                _ballance = value;
            }
        }

        public BankAccount(PersonalData client)
        {
            this.client = client;
            Random rnd = new Random();
            idAccount = rnd.Next(1, 9999);
        }
    }
}
