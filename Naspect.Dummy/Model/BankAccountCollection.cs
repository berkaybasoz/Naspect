using System.Collections.Generic;

namespace Naspect.Dummy.Model
{
    public class BankAccountCollection : List<BankAccount>
    {
        public BankAccountCollection()
        {

        }

        public BankAccountCollection(IEnumerable<BankAccount> accounts)
        {
            AddRange(accounts);
        }
    }
}
