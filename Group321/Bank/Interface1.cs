using System.Collections.Generic;

namespace Bank
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
