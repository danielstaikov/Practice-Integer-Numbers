using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs( int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvensAndOdds(number));
        }
        static int GetMultipleOfEvensAndOdds(int n)
        {
            return GetSumOfEvenDigits(n)* GetSumOfOddDigits(n);
        }
        static int GetSumOfEvenDigits(int n)//четен
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum = sum + lastDigit;

                }
                n /= 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int n)//нечетен
        {
            int sum = 0;
            while (n>0)
            {
                int lastDigit = n % 10;
                if (lastDigit%2!=0)
                {
                    sum =sum +lastDigit ;

                }
                n /= 10;
            }
            return sum;
        }
    }
}
