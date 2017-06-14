using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double result = GetSquared(n);
            Console.WriteLine(result);
            Console.WriteLine(RaseToPower(n,3));
        }
        static double GetSquared(double num)
        {
            return num * num;
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
