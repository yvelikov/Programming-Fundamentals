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
            var entry = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var registedredUsers = new Dictionary<string, DateTime>();

            while (entry[0] != "end")
            {
                var name = entry[0];
                var inputDate = entry[1];
                string format = "dd/MM/yyyy";
                DateTime parsedDate = DateTime.ParseExact(inputDate,format,CultureInfo.InvariantCulture);

                if (!registedredUsers.ContainsKey(name))
                {
                    registedredUsers[name] = new DateTime();
                }
                if (registedredUsers.ContainsValue(parsedDate))
                {
                    parsedDate = parsedDate.AddMinutes(1);
                }
                registedredUsers[name] = parsedDate;


                entry = Console.ReadLine()
                .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            }

            var oldestUsers = registedredUsers
                .OrderByDescending(dt => dt.Value.Date)
                .ToList();

            var count = oldestUsers.Count();

            var usersToPrint = oldestUsers
                .Skip(count - 5)
                .OrderBy(dt => dt.Value)
                .Reverse()
                .ToList();
                

            foreach (var user in usersToPrint)
            {
                Console.WriteLine(user.Key);
            }
           
        }
    }
}
