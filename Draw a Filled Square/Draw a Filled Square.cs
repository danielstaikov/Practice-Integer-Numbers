using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintEndRow(n);
            for (int i = 1; i < n-1; i++)
            {
                PrintMidRow(n);
            }
            PrintEndRow(n);
        }
        static void PrintEndRow(int n)
        {
            Console.WriteLine(new string('-',2*n));
        }
        static void PrintMidRow(int n)
        {
            Console.Write('-');
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");

            }
            Console.WriteLine('-');
        }
    }
}
