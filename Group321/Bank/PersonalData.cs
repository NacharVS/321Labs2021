using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    struct PersonalData
    {
        string _name;
        string _surname;
        string _addres;
        Account account;


        public PersonalData(string _name, string _surname, string _addres, Account account)
        {
            this._name = _name;
            this._surname = _surname;
            this._addres = _addres;
            this.account = account;
        }
    }

}
