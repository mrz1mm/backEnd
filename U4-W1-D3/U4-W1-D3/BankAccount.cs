using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4_W1_D3
{
    public class BankAccount
    {
        public int Id { get; }
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }
        public string Currency { get; set; }
        public string AccountType { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Status { get; set; }
        public List<Transaction> Transactions { get; set; }

        public BankAccount(int id, string accountNumber, string accountHolder, decimal balance, string currency, string accountType, DateTime creationDate, bool status)
        {
            Id = id;
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
            Currency = currency;
            AccountType = accountType;
            CreationDate = creationDate;
            Status = false;
            Transactions = new List<Transaction>();
        }

        public void OpenBankAccount()
        {
            if (Status == true)
            {
                Console.WriteLine($"Account is already open and your balance is {Balance}");
                return;

            }

            if (Status == false)
            {
                if (Balance < 1000)
                {
                    Console.WriteLine("For open the AccountBank you must deposit a min of 1000,00");
                    return;
                }

                if (Balance >= 1000)
                {
                    Console.WriteLine("Now your Account is open");
                    Status = true;
                }
            }
        }

        public void Deposit(decimal amount, string causal)
        {
            Balance += amount;
            Transactions.Add(new Transaction(DateTime.Now, amount, causal));
            Console.WriteLine($"You have deposited {amount} and now your balance is {Balance}");
        }

        public void Withdraw(decimal amount, string causal)
        {
            Balance -= amount;
            Transactions.Add(new Transaction(DateTime.Now, -amount, causal));
            Console.WriteLine($"You have withdrawn {amount} and now your balance is {Balance}");
        }

        public void Transfer(BankAccount destination, decimal amount, string causal)
        {
            Balance -= amount;
            destination.Balance += amount;
            Transactions.Add(new Transaction(DateTime.Now, -amount, causal));
            destination.Transactions.Add(new Transaction(DateTime.Now, amount, causal));
            Console.WriteLine($"You have transferred {amount} to {destination.AccountHolder} and now your balance is {Balance}");
        }
    }
}
