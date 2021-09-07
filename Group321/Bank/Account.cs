using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Account
    {
        private double _balanse;

        public double Balanse
        {
            get => _balanse;
            set
            {
                _balanse = value;
            }
        }
    }
}
