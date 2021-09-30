using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    struct PersonalData
    {
        private string fio;
        private string adress;
        public string FIO { get => fio; set => fio = value; }
        public string Adress { get => adress; set => adress = value; }

        public PersonalData(string fio,string adress)
        {
            this.fio = fio;
            this.adress = adress;
        }
    }
}
