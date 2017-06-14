using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_Terabytes_to_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1TB == (1024 * 1024 * 1024 * 1024 * 8) bits
            double size = double.Parse(Console.ReadLine());
            double bytes = (double)Math.Pow( 1024,4) * 8 * size;
            Console.WriteLine($"{bytes}");
        }
    }
}
