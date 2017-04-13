namespace _01.RegisterUsers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class RegisterUsers
    {
        public static void Main()
        {
            var entry = Console.ReadLine();

            Dictionary<string,DateTime> registeredUsers = new Dictionary<string, DateTime>();

            while (entry != "end")
            {
                var userParams = entry.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var username = userParams[0];
                var registryDate = DateTime.ParseExact(userParams[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                registeredUsers[username] = registryDate;

                entry = Console.ReadLine();
            }

            registeredUsers = registeredUsers
                .OrderByDescending (x => x.Value)
                .Reverse()
                .Take(5)
                .OrderByDescending(x=> x.Value)
                .ToDictionary(x=> x.Key, x => x.Value);

            foreach (var user in registeredUsers)
            {
                Console.WriteLine(user.Key);
            }
        }
    }
}
