using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.TravelingAtLightSpeed
{
    class TravelingAtLightSpeed
    {
        static void Main(string[] args)
        {
            decimal numerOfLightYears = decimal.Parse(Console.ReadLine());
            decimal distanceInKilometers = numerOfLightYears * 945e+10m;
            decimal speed = 3e+5m;
            decimal distanceForOneWeek = 7m * 24m * 60m * 60m*speed;
            decimal distanceForOneDay = 24m * 60m * 60m * speed;
            decimal distanceForOneHour = 60m * 60m * speed;
            decimal distanceForOneMinute = 60m * speed;
            decimal distanceForOneSecond = speed;
            decimal totalWeeks = distanceInKilometers / distanceForOneWeek;
            decimal totalDays = distanceInKilometers / distanceForOneDay;
            decimal totalHours = distanceInKilometers / distanceForOneHour;
            decimal totalMinutes = distanceInKilometers / distanceForOneMinute;
            decimal totalSeconds = distanceInKilometers / distanceForOneSecond;
            
            Console.WriteLine("{0:f0} weeks", totalWeeks);
            decimal integerWeeks = Math.Floor(totalWeeks);
            Console.WriteLine("{0:f0 days}", totalDays - integerWeeks*7 );
            decimal integerDays = Math.Floor(totalDays);
            Console.WriteLine("{0:f0 hours}",totalHours-integerDays*24);
            decimal integerHours = Math.Floor(totalHours);
            Console.WriteLine("{0:F0 minutes}",totalMinutes-integerHours*60);
            decimal integerMinutes = Math.Floor(totalMinutes);
            Console.WriteLine("{0:f0 seconds}", totalSeconds-integerMinutes*60);

            
        }
    }
}
