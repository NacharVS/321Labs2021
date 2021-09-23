using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    struct PersonalData
    {
        public string fio;
        public string adress;
        public Account acc;

        public PersonalData(string fio,string adress, Account acc)
        {
            this.fio = fio;
            this.adress = adress;
            this.acc = acc;
        }
    }
}
