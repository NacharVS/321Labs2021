using bank1;
using Baseline.ImTools;
using LamarCodeGeneration.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
        struct PersonalData 
    {
        public string FIO;
        public string Adress;
        public Account account;

        public PersonalData(string Name, string adress, Account account)
        {
            this.FIO = Name;
            this.Adress = adress;
            this.account = account;

        }
    }
}
