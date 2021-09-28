using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group321
{
    struct PersonalData
    {
        //добавить свойства
        public string _FIO;
        public string _addres;
        public Account _acc;

        public string FIO { get => _FIO; set => _FIO = value; }
        public string Addres { get => _addres; set => _addres = value; }
        public Account Acc { get => _acc; set => _acc = value; }

        public PersonalData(string FIO, string addres, Account acc)
        {
            _FIO = FIO;
            _addres = addres;
            _acc = acc;
        }
    }
}
