namespace U4_W1_D3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1, "123456", "John Doe", 1000, "USD", "Savings", DateTime.Now, false);
            BankAccount account2 = new BankAccount(2, "123457", "Jane Doe", 1000, "USD", "Savings", DateTime.Now, false);
            account.OpenBankAccount();
            account.Deposit(500, "Initial deposit");
            account.Deposit(200, "Second deposit");
            account.Transfer(account2, 300, "Transfer to account 2");
            account2.Withdraw(100, "Withdraw from account 2");

            NameList nameList = new NameList();
            nameList.SearchName();

            NumberArray numberArray = new NumberArray();
            numberArray.GetNumberArray();
        }
    }
}
