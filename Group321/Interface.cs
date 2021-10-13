using System;
using System.Collections.Generic;
using System.Text;

namespace Group321
{
    interface IAccountOperations
    {
        List<Account> Lst { get; set; }
        void RemoveList(Account acc, int a);
        void AddList();
        void Reduct();
        int ChooseAcc();
    }
}