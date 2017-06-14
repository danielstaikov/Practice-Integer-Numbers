using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance_of_The_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal lightYear = 9450000000000;
            decimal proximaCentauri = (decimal)4.22 *lightYear;
            decimal distanceToMilkyWay = 26000 * lightYear;
            decimal diameterMilkyWay = 100000 * lightYear;
            decimal observableUniverse = 46500000000 * lightYear;
            Console.WriteLine($"{proximaCentauri:e2}");
            Console.WriteLine($"{distanceToMilkyWay:e2}");
            Console.WriteLine($"{diameterMilkyWay:e2}");
            Console.WriteLine($"{observableUniverse:e2}");

        }
    }
}
