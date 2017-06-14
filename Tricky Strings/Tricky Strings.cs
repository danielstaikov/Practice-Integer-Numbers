using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tricky_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string delimit = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string text = null;
            string word = Console.ReadLine();
            text = text + word;
            for (int i = 1; i < number; i++)
            {
                word = Console.ReadLine();
                text = text + delimit+word;
                
            }

            Console.WriteLine(text); 
        }
    }
}
