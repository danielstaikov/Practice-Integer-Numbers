using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string text = null;
            for (int i = 0; i < number; i++)
            {
                int ascii = int.Parse(Console.ReadLine());
                char letter = (char)ascii;
                text =text + letter;

            }
            Console.WriteLine(text);
        }
    }
}
