using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1
{
    class BankAccount
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
 
        public double Percent
        {
            get; set;
        }

        public string id
        {
            get; set;
        }


       

    }
}
