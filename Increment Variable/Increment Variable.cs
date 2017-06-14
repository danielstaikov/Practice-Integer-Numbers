using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int result = a / 255;

            if (a<=255&&a>=-255)
            {
                Console.WriteLine($"{a}");
            }
            else
            {
                int over = Math.Abs( a - result * 256);
                Console.WriteLine($"{over}");
                Console.WriteLine($"Overflowed {Math.Abs(result)} times");
            }
        }
    }
}
