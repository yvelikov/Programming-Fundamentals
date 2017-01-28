using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            Console.WriteLine(distanceInMeters/(hours*3600+minutes*60+seconds));
            Console.WriteLine(distanceInMeters/1000/(hours+minutes/60+seconds/3600));
            Console.WriteLine(distanceInMeters/1609/ (hours + minutes / 60 + seconds / 3600));


        }
    }
}
