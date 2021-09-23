using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Employee : Account
    {
        public override double StavkaCred { get => base.StavkaCred; set => base.StavkaCred = value; }
        public override double StavkaVklad { get => base.StavkaVklad; set => base.StavkaVklad = value; }
        public Employee(double balance)
        {
            this.balance = balance;   
        }

        public Employee()
        {
            StavkaVklad = 10;
            StavkaCred = 2;
        }
    }
}
