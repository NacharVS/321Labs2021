using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Account
    {
        private double _balanse;
        private static double _rate = 0.057;

        public double Balanse
        {
            get => _balanse;
            set
            {
                _balanse = value;
            }
        }

        public double Rate
        {
            get => _rate;
            set
            {
                _rate = value;
            }
        }

    }
}
