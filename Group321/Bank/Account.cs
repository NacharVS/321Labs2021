using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    class Account
    {
        private double _balanse;
        private static double _rate = 0.057;
        private string _surname;
        private string _name;

        public double Balanse
        {
            get => _balanse;
            set
            {
                if (_balanse > 0)
                {
                    _balanse = value;
                }
                
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

        public string Surname 
        { 
            get => _surname; 
            set => _surname = value; 
        }
        public string Name 
        { 
            get => _name; 
            set => _name = value; 
        }
    }
}
