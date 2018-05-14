using Naspect.Attribute.Activity;
using Naspect.Attribute.Authorize;
using Naspect.Attribute.Cache;
using Naspect.Attribute.Exception;
using Naspect.Attribute.Log;
using Naspect.Attribute.Thread;
using Naspect.Dummy.Model;
using System;
using System.Linq;
using System.Threading;
using System.Dynamic;

namespace Naspect.Dummy.Service
{
    public class DummyBankAccountService : IBankAccountService 
    {
        private static BankAccountCollection bankAccounts = new DummyBankAccountCollection();
  
        [Log]
        [Cache(DurationInMinute = 10)]
        public BankAccountCollection GetBankAccounts(int branchCode)
        {
            Thread.Sleep(1000);
            return new BankAccountCollection(bankAccounts.Where(w => w.BranchCode == branchCode));
        }

        ////[Run(()=> { Console.WriteLine("")}, 
        ////    () => { Console.WriteLine("")}, 
        ////    () => { Console.WriteLine("")})]
        //[Run(typeof(Core.Interception.IPreVoidInterception))]
        //[Run(OnBefore = typeof(PreAction<int>) )]
        //[Run(OnBefore = new ExpandoObject()))]
        public BankAccountCollection GetBankAccountForGeneric(int branchCode)
        {
            Console.WriteLine(((dynamic)new ExpandoObject()).phrase);
            Thread.Sleep(1000);
            return new BankAccountCollection(bankAccounts.Where(w => w.BranchCode == branchCode));
        }

        [ThreadLock]
        [Authorize(Roles = new string[] { "Admin" })]
        public void WithDraw(int accountNumber, decimal money)
        { 
        }

        [Exception]
        public void Deposit(int accountNumber, decimal money)
        {
            // Exception attribute içerisinde burda fırlattığımız hatayı loglayıp friendly name ile değiştireceğiz
            throw new NotImplementedException();
        }



    }
}
