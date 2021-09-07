using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    struct PersonalData
    {
        string name;
        string surname;
        string patronymic;
        string adress;
        string idaccount;
        string age;
        Account acc;

        public PersonalData(string name, string surname, string patronymic, string adress, string idaccount, string age, Account acc)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
            this.adress = adress;
            this.idaccount = idaccount;
            this.age = age;
            this.acc = acc;
        }
    }
}
