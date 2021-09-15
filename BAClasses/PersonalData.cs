using System;
using System.Collections.Generic;
using System.Text;

namespace BAClasses
{
    public struct PersonalData
    {
        private string _FName, _LName, _TNumber, _BDate, _persAccNum; 

        public PersonalData(string _FName, string _LName, string _TNumber, string _BDate, string _persAccNum)
        {
            this._FName = _FName;
            this._LName = _LName;
            this._TNumber = _TNumber;
            this._BDate = _BDate;
            this._persAccNum = _persAccNum;
        }
        
        public void GetPersonalData()
        {
            Console.WriteLine("New client is added!");
            Console.WriteLine($"Client: {_FName} {_LName}");
            Console.WriteLine($"Personal account number: {_persAccNum}");
            Console.WriteLine($"Birth date: {_BDate}");
            Console.WriteLine($"Telephone Number: {_TNumber}");
        }
    }
}
