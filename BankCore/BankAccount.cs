using System;
using System.Collections.Generic;

namespace BankCore
{
    public class BankAccount : IBankAccount
    {
        private PersonalData client;
        private int _idAccount;

        public int idAccount
        {
            get => _idAccount;
            set
            {
                _idAccount = value;
            }
        }

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
            _idAccount = rnd.Next(1, 9999);
        }

        public PersonalData ClientStuff()
        {
            return client;
        }

        public void BanAccount()
        {
            if(this.Ballance < 0)
            {
                this.idAccount = -1;
            }
        }

        double IBankAccount.Ballance()
        {
            throw new NotImplementedException();
        }
    }
}
