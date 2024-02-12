using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classec
{
    public class BankAccount
    {
        private static int s_AccountNumberSeed = 1234567890;
        public string AccountNumber { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (Transaction transaction in _allTransactions)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }
        }

        private List<Transaction> _allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "youre mf initial BALANCE PEDO!!NO.1 IN THE UNIVERSE");
            AccountNumber = s_AccountNumberSeed.ToString();
            s_AccountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)

        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "deposit must be positive mf ");
            }
            Transaction deposit = new Transaction(amount, date, note);
            _allTransactions.Add(deposit);

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "deposit valid number less than you pedophile");
            }
            if (Balance - amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "dont have enough money YOU CHILD MOLESTER!!");
            }
            Transaction withdraw = new Transaction(-amount, date, note);
            _allTransactions.Add(withdraw);
        }
        public string GetAccountHistory()
        {
            StringBuilder report = new StringBuilder();
            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach(Transaction transaction in _allTransactions)
            {
                balance += transaction.Amount;
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{balance}\t{transaction.Notes}");
            }

            return report.ToString();
        }


    }
}
