using Naspect.Dummy.Model;

namespace Naspect.Dummy.Service
{
    public interface IBankAccountService
    {
        BankAccountCollection GetBankAccounts(int branchCode);
        BankAccountCollection GetBankAccountForGeneric(int branchCode);
        void WithDraw(int accountNumber, decimal money);
        void Deposit(int accountNumber, decimal money);
    }
}
