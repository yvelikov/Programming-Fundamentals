namespace _02.OptimizedBankSyst
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BankAccount
    {
        public string Name { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }
    }

    public class OptimizedBankingSystem
    {
        public static void Main()
        {
            var entry = Console.ReadLine();

            var listOfAccounts = new List<BankAccount>();

            while (entry != "end")
            {
                var currentBankAccount = CreateAccount(entry);
                listOfAccounts.Add(currentBankAccount);

                entry = Console.ReadLine();
            }

            foreach (var account in listOfAccounts.OrderByDescending(x=>x.Balance).ThenBy(x=>x.Bank.Length))
            {
                Console.WriteLine($"{account.Name} -> {account.Balance} ({account.Bank})");
            }
        }

        public static BankAccount CreateAccount(string entry)
        {
            var bankDetails = entry.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
            var currentBankAccount = new BankAccount
            {
                Bank = bankDetails[0],
                Name = bankDetails[1],
                Balance = decimal.Parse(bankDetails[2])
            };
            return currentBankAccount;
        }
    }
}
