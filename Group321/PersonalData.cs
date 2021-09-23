using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    struct PersonalData
    {
         public string FIO;
       public  string addres;
         public Account account;
        public PersonalData(string FIO,string addres,Account account)
        {
            this.FIO = FIO;
            this.addres = addres;
            this.account = account;
        }
    }
}
