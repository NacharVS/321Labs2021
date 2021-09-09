using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group321
{
    class Employee : Account
    {
        public override double ProcentStavkaCredit { get => base.ProcentStavkaCredit; set => base.ProcentStavkaCredit = value; }
        public override double ProcentStavkaVklad { get => base.ProcentStavkaVklad; set => base.ProcentStavkaVklad = value; }
    }
}
