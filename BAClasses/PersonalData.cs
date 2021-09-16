using System;
using System.Collections.Generic;
using System.Text;

namespace BAClasses
{
    public struct PersonalData
    {
        private string _FName, _LName, _TNumber, _BDay, _BMonth, _BYear;

        public PersonalData(string FName, string LName, string TNumber, string BDay, string BMonth, string BYear)
        {
            _FName = FName;
            _LName = LName;
            _TNumber = TNumber;
            _BDay = BDay;
            _BMonth = BMonth;
            _BYear = BYear;
        }   
        
        public void GetPersonalData()
        {
            Console.WriteLine("New client is added!");
            Console.WriteLine($"Client: {_FName} {_LName}");

            Random rnd = new Random();
            int frstThreeNum = rnd.Next(100, 999);
            int scndThreeNum = rnd.Next(100, 999);
            int thrdThreeNum = rnd.Next(100, 999);
            int frthThreeNum = rnd.Next(100, 999);
            int ffthThreeNum = rnd.Next(100, 999);

            string fTN = Convert.ToString(frstThreeNum);
            string sTN = Convert.ToString(scndThreeNum);
            string tTN = Convert.ToString(thrdThreeNum);
            string frTN = Convert.ToString(frthThreeNum);
            string ffTN = Convert.ToString(ffthThreeNum);
            
            Console.WriteLine("Personal account number: 4" + fTN + sTN + tTN + frTN + ffTN);
            
            Console.WriteLine($"Birth date: {_BDay}.{_BMonth}.{_BYear}");
            Console.WriteLine($"Telephone Number: {_TNumber}");
        }
    }
}
