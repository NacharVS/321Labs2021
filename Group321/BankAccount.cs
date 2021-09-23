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

    class Employee : BankAccount
    { 
        public string EName
        {
            get; set;
        }

        public double min
        {
            get; set;
        }
        // Минимальная зарплата 
        public double k
        {
            get; set;
        }
        // Коэффициент 
    }

    class Client : BankAccount
    {
        public string CName
        {
            get; set;
        }

        public string Login
        {
            get; set;
        }

        public string Password
        {
            get; set;
        }


    }

    class Administrator : BankAccount
    {
        public string AName
        {
            get; set;
        }

        public string Email
        {
            get; set;
        }
    }

}