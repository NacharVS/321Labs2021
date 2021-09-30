using System.Collections.Generic;

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
