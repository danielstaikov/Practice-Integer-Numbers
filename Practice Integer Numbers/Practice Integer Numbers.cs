﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //-100
            //128
            //- 3540
            //64876
            //2147483648
            //- 1141583228
            //- 1223372036854775808

            sbyte a = -100;
            byte b = 128;
            short c = -3540;
            ushort d = 64876;
            uint e = 2147483648;
            int f = -1141583228;
            long g = -1223372036854775808;
            Console.WriteLine($"{a}");
            Console.WriteLine($"{b}");
            Console.WriteLine($"{c}");
            Console.WriteLine($"{d}");
            Console.WriteLine($"{e}");
            Console.WriteLine($"{f}");
            Console.WriteLine($"{g}");

        }
    }
}
