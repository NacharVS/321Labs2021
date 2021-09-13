using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Account
    {
        private double balance;
        private double credit;
        private double vklad;
        private double timevklad;
        public double Balance { get => balance; set => balance = value; }
        public double Credit { get => credit; set => credit = value; }
        public double Vklad { get => vklad; set => vklad = value; }
        public double timeVklad { get => timevklad; set => timevklad = value; }
    }
}
