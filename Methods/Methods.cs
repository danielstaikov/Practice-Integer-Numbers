using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintRoof(n);
            PrintBase(n);
        }
        static void PrintBase(int n)
        {
            Console.WriteLine(new string('-',n));
        }
        static void PrintRoof(int n)
        {
            int left = n / 2;
            int right = left;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (col == left || col == right)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                left--;
                right++;

            }
        }
    }
}