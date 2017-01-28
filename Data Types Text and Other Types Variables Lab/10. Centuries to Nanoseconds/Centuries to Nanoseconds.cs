using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            uint centuries = uint.Parse(Console.ReadLine());
            byte years = 100;
            float days = 365.2422f;
            uint averageDays = (uint)(days*centuries*years);
            uint hours = averageDays * 24;
            uint minutes = hours*60;
            ulong seconds = (ulong)minutes*60;
            ulong milliseconds = seconds*1000;
            ulong microseconds = milliseconds*1000;
            decimal nanoseconds = microseconds*1000m;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",centuries,centuries*years,averageDays,hours,minutes,seconds,milliseconds,microseconds,nanoseconds);




        }
    }
}
