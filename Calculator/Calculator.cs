using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstOperand = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            int secondOperand = int.Parse(Console.ReadLine());
            switch (oper)
            {
                case "+":
                    Console.WriteLine($"{firstOperand} + {secondOperand} = {firstOperand+ secondOperand}");
                    break;
                case "-":
                    Console.WriteLine($"{firstOperand} - {secondOperand} = {firstOperand - secondOperand}");
                    break;
                case "*":
                    Console.WriteLine($"{firstOperand} * {secondOperand} = {firstOperand * secondOperand}");
                    break;
                case "/":
                    Console.WriteLine($"{firstOperand} / {secondOperand} = {firstOperand / secondOperand}");
                    break;
            }

        }
    }
}
