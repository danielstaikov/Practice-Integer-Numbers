using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(RaseToPower(n, power));
        }
        static double RaseToPower(double n, int power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= n;
            }
            return result;
        }
    }
}
