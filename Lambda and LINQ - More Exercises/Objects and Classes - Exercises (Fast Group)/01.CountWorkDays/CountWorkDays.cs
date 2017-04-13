namespace _01.CountWorkDays
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class CountWorkDays
    {
        public static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),"dd-MM-yyyy",CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var holidaysAsList = new List<DateTime>();

            for (int i = startDate.Year; i <= endDate.Year; i++)
            {
                var arryayOfHolidays = new DateTime[]
                    {
                        new DateTime(i, 01, 01),
                        new DateTime(i, 03, 03),
                        new DateTime(i, 05, 01),
                        new DateTime(i, 05, 06),
                        new DateTime(i, 05, 24),
                        new DateTime(i, 09, 06),
                        new DateTime(i, 09, 22),
                        new DateTime(i, 11, 1),
                        new DateTime(i, 12, 24),
                        new DateTime(i, 12, 25),
                        new DateTime(i, 12, 26),
                    };
              
                foreach (var date in arryayOfHolidays)
                {
                    holidaysAsList.Add(date);
                }
            }

            var count = 0;

            for (DateTime day = startDate; day <= endDate; day = day.AddDays(1))
            {
                var currentDay = day.DayOfWeek.ToString();
                
                if (!holidaysAsList.Contains(day) && currentDay != "Saturday" && currentDay != "Sunday")
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
