using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "string":
                    string one = Console.ReadLine();
                    string two = Console.ReadLine();
                    Console.WriteLine(GetMax(one,two));
                    break;
                case "int":
                    int uno = int.Parse(Console.ReadLine());
                    int due = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(uno, due));
                    break;
                case "char":
                    char first = char.Parse(Console.ReadLine());
                    char second = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(first, second));
                    break;
            }

        }
        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second)>=0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char GetMax(char one, char two)
        {
            if (one >= two)
            {
                return one;
            }
            else
            {
                return two;
            }
        }
        static int GetMax(int one, int two)
        {
            if (one>=two)
            {
                return one;
            }
            else
            {
                return two;
            }
        }
    }
}
