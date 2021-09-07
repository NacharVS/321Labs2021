using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    struct PersonalData
    {
        public string name;
        public int age;
        Account myAcc;

        public void Info()
        {
            Console.WriteLine($"Name: {name}  Age: {age} Acc: {myAcc}");
        }
    }
}
