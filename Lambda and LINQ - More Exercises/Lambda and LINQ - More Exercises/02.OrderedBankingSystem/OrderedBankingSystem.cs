namespace _02.OrderedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderedBankingSystem
    {
        public static void Main()
        {
            var entry = Console.ReadLine();

            var bankDetails = new Dictionary<string, Dictionary<string, decimal>>();

            while (entry != "end")
            {
                
                var bankParams = entry.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var bankName = bankParams[0];
                var account = bankParams[1];
                var balance = decimal.Parse(bankParams[2]);

                if (!bankDetails.ContainsKey(bankName))
                {
                    bankDetails[bankName] = new Dictionary<string, decimal>();
                }
                if (bankDetails[bankName].ContainsKey(account))
                {
                    balance = balance + bankDetails[bankName][account];
                }
                bankDetails[bankName][account] = balance;

                entry = Console.ReadLine();

            }

            bankDetails = bankDetails
                .OrderByDescending(x => x.Value.Sum(y => y.Value))
                .ThenByDescending(x => x.Value.Max(y => y.Value))
                //.ThenBy(x => x.Value.OrderByDescending(y => y.Value))
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var bank in bankDetails)
            {
                foreach (var account in bank.Value.OrderByDescending(x=>x.Value))
                {
                    Console.Write(account.Key + " -> " + account.Value);
                    Console.WriteLine($" ({bank.Key})");
                }
            }
        }
    }
}
