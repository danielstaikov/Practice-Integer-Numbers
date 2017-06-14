using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            string input =Console.ReadLine();
            ulong numberUlong = 0;
            long numberLong = 0;

            bool resultUlong = ulong.TryParse(input, out numberUlong);
            bool resultLong = long.TryParse(input, out numberLong);

             if (resultUlong)
             {
                if (numberUlong >= byte.MinValue && numberUlong <= byte.MaxValue)
                {
                    Console.WriteLine("smaller type: byte");
                }
                else if (numberUlong >= ushort.MinValue && numberUlong <= ushort.MaxValue)
                {
                    Console.WriteLine("smaller type: ushort");
                }
                else if (numberUlong >= uint.MinValue && numberUlong <= uint.MaxValue)
                {
                    Console.WriteLine("smaller type: uint");
                }
                else
                {
                    Console.WriteLine("smaller type: ulong");
                }
                
                // byte.MinValue ≤ number ≤ byte.MaxValue
                // ushort.MinValue ≤ number ≤ ushort.MaxValue
                // uint.MinValue ≤ number ≤ uint.MaxValue
                //else>> ulong

            }
            else
            {
                if (numberLong >= sbyte.MinValue && numberLong <= sbyte.MaxValue)
                {
                    Console.WriteLine("smaller type: sbyte");
                }
                else if (numberLong >= short.MinValue && numberLong <= short.MaxValue)
                {
                    Console.WriteLine("smaller type: short");
                }
                else if (numberLong >= int.MinValue && numberLong <= int.MaxValue)
                {
                    Console.WriteLine("smaller type: int");
                }
                else
                {
                    Console.WriteLine("smaller type: long");
                }
                // sbyte.MinValue ≤ number ≤ sbyte.MaxValue
                // short.MinValue ≤ number ≤ short.MaxValue
                // int.MinValue ≤ number ≤ int.MaxValue
                //else >> long.MinValue ≤ number ≤ long.MaxValue
            }
            //






            //   sbyte -128 to 127
            //   byte 0 to 255
            //   short -32,768 to 32,767
            //   ushort 0 to 65,535
            //   int -2,147,483,648 to 2,147,483,647
            //   uint 0 to 4,294,967,295
            //   long -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            //   ulong 0 to 18,446,744,073,709,551,615


            Console.WriteLine($"{numberUlong}");
            Console.WriteLine($"{numberLong}");
        }
    }
}
