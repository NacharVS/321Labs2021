using System;
using System.Collections.Generic;
using System.Text;

namespace BankCore
{
    interface IBankAccount
    {
        double Ballance();

        PersonalData ClientStuff();
    }
}
