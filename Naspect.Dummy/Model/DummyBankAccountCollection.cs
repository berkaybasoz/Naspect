namespace Naspect.Dummy.Model
{
    public class DummyBankAccountCollection : BankAccountCollection
    {
        public DummyBankAccountCollection()
        {
            Add(new BankAccount() { AccountNumber = 1, BranchCode = 1, Money = 500 });
            Add(new BankAccount() { AccountNumber = 2, BranchCode = 2, Money = 400 });
            Add(new BankAccount() { AccountNumber = 3, BranchCode = 1, Money = 300 });
            Add(new BankAccount() { AccountNumber = 4, BranchCode = 2, Money = 200 });
        }
    }
}
