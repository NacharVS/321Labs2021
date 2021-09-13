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

    class DebitAccount
    {
        private double _ballance_debit = 0;

        public double Ballance_debit
        {
            get => _ballance_debit;
            set
            {
                _ballance_debit = value;
            }

        }
        static void stavka(DebitAccount accountDep, double summ, double mounth)
        {
            accountDep.Ballance_debit = accountDep.Ballance_debit + summ * 0.057 / 12 * mounth;
        }

    }
}
