using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Account
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
    }

    class CreditAccount
    {
        private double _ballance_credit = 0;

        public double BallanceCredit
        {
            get => _ballance_credit;
            set
            {
                _ballance_credit = value;
            }

        }
        

    }
}
