using System;
using System.Collections.Generic;
using System.Text;

namespace Group321.Bank
{
    class Client
    {
        string _name;
        string _surname;
        double _rate;

        public Client(string name, string surname, double rate)
        {
            _name = name;
            _surname = surname;
            _rate = rate;
        }
    }
}
