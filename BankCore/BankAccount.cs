using System;
using System.Collections.Generic;

namespace BankCore
{
    public class BankAccount
    {

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
    }
}
