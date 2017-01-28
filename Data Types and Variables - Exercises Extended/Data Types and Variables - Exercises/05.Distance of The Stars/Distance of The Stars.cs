using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05.Distance_of_The_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal distanceToProximaCentauri = 4.22m * 9450000000000m;
            decimal distanceToTheCenter = 26000m* 9450000000000m;
            decimal diameterOfMilkyWay = 100000m* 9450000000000m;
            decimal distanceToTheEdge = 46500000000m* 9450000000000m;
            Console.WriteLine(distanceToProximaCentauri.ToString("e2", CultureInfo.InvariantCulture));
            Console.WriteLine(distanceToTheCenter.ToString("e2", CultureInfo.InvariantCulture));
            Console.WriteLine(diameterOfMilkyWay.ToString("e2", CultureInfo.InvariantCulture));
            Console.WriteLine(distanceToTheEdge.ToString("e2", CultureInfo.InvariantCulture));
            
        }
    }
}
