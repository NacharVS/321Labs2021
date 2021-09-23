using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    struct PersonalData
    {
        string name;
        string surname;
        string addres;
        Account account;

        public PersonalData(string name, string surname, string addres, Account account)
        {
            this.name = name;
            this.surname = surname;
            this.addres = addres;
            this.account = account;
        }
    }
}
