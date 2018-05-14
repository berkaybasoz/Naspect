using Naspect.Container;
using Naspect.Container.Unity;
using Naspect.Core.Container;
using Naspect.Dummy.Model;
using Naspect.Dummy.Service;
using System;

namespace Naspect.Test.Console
{
    class Program
    {
        static void Main(string[] args)
        {


            IContainerFactory containerFactory= new UnityContainerFactory();
            ContainerContext.ContainerFactory = containerFactory;
            BootStrapper.Configure(ContainerContext.Instance);


            IBankAccountService productService = BankAccountServiceFactory.CreateTransparentProxy();

            int branchCode = 1, accountNumber = 1000;
            BankAccountCollection bankAccounts;

            Run(() =>
            {
                //accounts will come from the service as expected
                bankAccounts = productService.GetBankAccounts(branchCode);
                foreach (var bankAccount in bankAccounts)
                {
                    System.Console.WriteLine(bankAccount.ToString());
                }
            });


            Run(() =>
            {
                //[Cache] it must come from cache
                bankAccounts = productService.GetBankAccounts(branchCode);
                foreach (var bankAccount in bankAccounts)
                {
                    System.Console.WriteLine(bankAccount.ToString());
                }
            });

            Run(() =>
            {
                //[Authorize] only user who has Admin role, can execute
                productService.WithDraw(accountNumber, 200000);
            });

            Run(() =>
            {
                //[Exception] we retrow friendly error message
                productService.Deposit(accountNumber, 200000);
            });

            System.Console.ReadLine();
        }

        public static void Run(Action action)
        {
            try
            {
                action();
            }
            catch (Exception ex)
            {
                System.Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Program main ex" + ex.ToString());
                System.Console.ResetColor();
            }
        }
    }
}
