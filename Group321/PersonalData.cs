using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group321
{
    struct PersonalData
    {
        string FIO;
        string addres;

        Account acc;


        public PersonalData(string FIO, string addres, Account acc)
        {
            this.FIO = FIO;
            this.addres = addres;
            this.acc = acc;
        }
    }
}
