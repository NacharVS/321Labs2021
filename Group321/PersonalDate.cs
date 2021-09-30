using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    class PersonalDate
    {
        private string _FName, _LName, _TNumber, _BDay;
        public PersonalDate(string FName, string LName, string TNumber,string BDay)
        {
            _FName = FName;
            _LName = LName;
            _TNumber = TNumber;
            _BDay = BDay;

        }
        public void GetPersonalData()
        {
            Console.WriteLine($"Your first name:{_FName} // Your last name: {_LName} // Your telephone number:{_TNumber} // Your birthday date: {_BDay} ");
        }
    }
}
