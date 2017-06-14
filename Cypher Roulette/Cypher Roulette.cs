using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cypher_Roulette
    {
        class Program
        {
            static void Main(string[] args)
            {
                int number = int.Parse(Console.ReadLine());
                string word = null;
                string wordDouble = null;
                string text = null;
                int spinCounter = 0;
                bool orderAdd = (spinCounter % 2 == 0);
                for (int i = 0; i < number; i++)
                {

                    word = Console.ReadLine();

                    if (word == wordDouble && word == "spin")
                    {
                        text = string.Empty;
                        word = string.Empty;
                        i--;
                    }
                    if (word == wordDouble)
                    {
                        text = string.Empty;
                        word = string.Empty;
                    }

                    wordDouble = word;

                    if (word == "spin")
                    {
                        word = string.Empty;

                        spinCounter++;
                        i--;
                        orderAdd = (spinCounter % 2 == 0);
                    }

                    else
                    {
                        if (orderAdd)
                        {
                            text = text + word;
                        }
                        else
                        {
                            text = word + text;
                        }

                    }
                }

                Console.WriteLine(text);
            }
        }
    }