using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group321
{
    class Account
    {
        private double balance;
        private double credit = 0;
        private double vklad = 0;

        public double Balance { get => balance; set => balance = value; }
        public double Credit { get => credit; set => credit = value; }
        public double Vklad { get => vklad; set => vklad = value; }

        public Account()
        {

        }

        public Account(double balance)
        {
            this.balance = balance;
        }
    }
}
