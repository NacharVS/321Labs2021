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
        public string balance;

        public PersonalData(string Name, string adress, string balance)
        {
            this.FIO = Name;
            this.Adress = adress;
            this.balance = balance; 

        }
    }
}
