namespace _01.SinoTheWalker
{
    using System;
    using System.Globalization;

    public class SinoTheWalker
    {
        public static void Main()
        {
            var time = Console.ReadLine();
            var steps = int.Parse(Console.ReadLine())%86400;
            var stepTime = int.Parse(Console.ReadLine())%86400;

            var startTime = new DateTime();

            startTime = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);

            double walkingTime = steps * stepTime;

            var timeOfArrival = startTime.AddSeconds(walkingTime);
            var arriavalAsString = timeOfArrival.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine("Time Arrival: " + arriavalAsString);

        }
    }
}