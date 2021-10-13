using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class PersonalDate
    {
        private string _FName, _LName, _TNumber, _BDay;
        public PersonalDate(string FName, string LName, string TNumber, string BDay)
        {
            _FName = FName;
            _LName = LName;
            _TNumber = TNumber;
            _BDay = BDay;

        }
        public void GetPersonalData()
        {
            Console.WriteLine($"Имя:{_FName} // Фамилия: {_LName} // Номер телефона:{_TNumber} // Дата рождения: {_BDay} ");
        }
    }
}