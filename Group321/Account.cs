﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class Account
    {
        private double bballance;

        public double Ballance
        {
            get => bballance; set
            {
                bballance = value;
            }
        }

        public string idAccount { get; set; }

        public double Percent { get; set; }

        public double Telephone { get; set; }
    }

    class Employee : Account
    {
        public string FullName { get; set; }

        public double Salary { get; set; }
    }

    class Client : Account
    {
        public string Password { get; set; }

        public string FullName { get; set; }
    }
}
