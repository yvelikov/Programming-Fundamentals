namespace _01.CharityMarathon
{
    using System;
    using System.Numerics;
   
    public class CharityMarathon
    {
        public static void Main()
        {
            var days = decimal.Parse(Console.ReadLine());
            var numberOfRunners = decimal.Parse(Console.ReadLine());
            var averageLaps = decimal.Parse(Console.ReadLine());
            var length = decimal.Parse(Console.ReadLine());
            var capacity = decimal.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            decimal runnersToRun = 0;

            decimal maximumRunners = days * capacity;
            if (numberOfRunners <= maximumRunners)
            {
                runnersToRun = numberOfRunners;
            }
            else runnersToRun = (capacity % numberOfRunners)*days;

            decimal totalMeters = averageLaps * length * runnersToRun;
            var totalKilometers = totalMeters / 1000m;
            var moneyRaisedPerKm = totalKilometers * moneyPerKm;

            Console.WriteLine($"Money raised: {moneyRaisedPerKm:F2}");

        }
    }
}
