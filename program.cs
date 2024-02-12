using System;

namespace Classec
{
    class Program
    {
        static void Main(string[] args)
        {
			BankAccount account = new BankAccount("PEDO",  10000);
            Console.WriteLine($"Account Number { account.AccountNumber} was created for{ account.Owner}the mf owner with {account.Balance} Billion pedomoney");
            account.MakeWithdrawal (500, DateTime.Now, "Loto win for raping 4 year old");
            Console.WriteLine(account.Balance);
            account.MakeDeposit(100, DateTime.Now, "Payment for sucking  a cock");
            Console.WriteLine(account.Balance);
            Console.WriteLine(account.GetAccountHistory());
           /* try
            {
                account.MakeWithdrawal(750, DateTime.Now, "attempt to overwithdraw");
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("CAUGHT TRYING TO OVERWITHDRAW TITS");
                Console.WriteLine(e.ToString());
            }*/
            BankAccount Molesteraccounts = new BankAccount("ass", 500);
            Console.WriteLine($"Account Number { Molesteraccounts.AccountNumber} was created for { Molesteraccounts.Owner} the mf owner with {Molesteraccounts.Balance} Billion pedomoney");
            account.MakeWithdrawal(300, DateTime.Now, "For Eating a babys genetelia");
            Console.WriteLine(account.Balance);

          /*  BankAccount InvalidBankAccount;
            try
            {
                InvalidBankAccount = new BankAccount("inavalid mf", 55);
            }
             catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creaing mf wrong value");
                Console.WriteLine(e.Message);
                return;
            }
          */

        }

    }
}
