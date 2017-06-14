using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Overflow_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong numberOne = ulong.Parse(Console.ReadLine());
            ulong numberTwo = ulong.Parse(Console.ReadLine());


            bool comparison = numberOne > numberTwo;

            if (comparison)
            {
                if (numberOne >= byte.MinValue && numberOne <= byte.MaxValue)
                {
                    Console.WriteLine("bigger type: byte");
                }
                else if (numberOne >= ushort.MinValue && numberOne <= ushort.MaxValue)
                {
                    Console.WriteLine("bigger type: ushort");
                }
                else if (numberOne >= uint.MinValue && numberOne <= uint.MaxValue)
                {
                    Console.WriteLine("bigger type: uint");
                }
                else
                {
                    Console.WriteLine("bigger type: ulong");
                }
                if (numberTwo >= byte.MinValue && numberTwo <= byte.MaxValue)
                {
                    Console.WriteLine("smaller type: byte");
                    Console.WriteLine($"{numberOne} can overflow byte {Math.Round((double)numberOne/byte.MaxValue,0)} times");

                }
                else if (numberTwo >= ushort.MinValue && numberTwo <= ushort.MaxValue)
                {
                    Console.WriteLine("smaller type: ushort");
                    Console.WriteLine($"{numberOne} can overflow ushort {Math.Round((double)numberOne / ushort.MaxValue,0)} times");
                }
                else if (numberTwo >= uint.MinValue && numberTwo <= uint.MaxValue)
                {
                    Console.WriteLine("smaller type: uint");
                    Console.WriteLine($"{numberOne} can overflow uint {Math.Round((double)numberOne / uint.MaxValue,0)} times");
                }
                else
                {
                    Console.WriteLine("smaller type: ulong");
                    Console.WriteLine($"{numberOne} can overflow ulong {Math.Round((double)numberOne / ulong.MaxValue,0)} times");
                }

            }
            else
            {
                if (numberTwo >= byte.MinValue && numberTwo <= byte.MaxValue)
                {
                    Console.WriteLine("bigger type: byte");

                }
                else if (numberTwo >= ushort.MinValue && numberTwo <= ushort.MaxValue)
                {
                    Console.WriteLine("bigger type: ushort");
                }
                else if (numberTwo >= uint.MinValue && numberTwo <= uint.MaxValue)
                {
                    Console.WriteLine("bigger type: uint");
                }
                else
                {
                    Console.WriteLine("bigger type: ulong");
                }
                if (numberOne >= byte.MinValue && numberOne <= byte.MaxValue)
                {
                    Console.WriteLine("smaller type: byte");
                    Console.WriteLine($"{numberTwo} can overflow byte {Math.Round((double)numberTwo / byte.MaxValue,0)} times");
                }
                else if (numberOne >= ushort.MinValue && numberOne <= ushort.MaxValue)
                {
                    Console.WriteLine("smaller type: ushort");
                    Console.WriteLine($"{numberTwo} can overflow ushort {Math.Round((double)numberTwo / ushort.MaxValue,0)} times");
                }
                else if (numberOne >= uint.MinValue && numberOne <= uint.MaxValue)
                {
                    Console.WriteLine("smaller type: uint");
                    Console.WriteLine($"{numberTwo} can overflow uint {Math.Round((double)numberTwo / uint.MaxValue,0)} times");
                }
                else
                {
                    Console.WriteLine("smaller type: ulong");
                    Console.WriteLine($"{numberTwo} can overflow ulong {Math.Round((double)numberTwo / ulong.MaxValue,0)} times");
                }


            }
        }
    }
}
