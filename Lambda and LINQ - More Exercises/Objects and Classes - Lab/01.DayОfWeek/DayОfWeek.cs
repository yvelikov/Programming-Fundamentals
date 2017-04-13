namespace _01.DayОfWeek
{
    using System;
    using System.Globalization;

    public class DayОfWeek
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var date = DateTime.ParseExact(input, "d-M-yyyy",CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);

        }
    }
}
